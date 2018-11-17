import cxapi = require('@aws-cdk/cx-api');
import colors = require('colors/safe');
import table = require('table');
import yargs = require('yargs');
import { print, warning } from '../../lib/logging';
import { collectMetadataEntries, combineMetadataEntries, Metadata } from '../api/cxapp/stacks';
import { CommandOptions } from '../command-api';

export const command = 'secrets [STACKS..]';
export const describe = 'Manage secrets referenced from your CDK app';
export const builder = {
  write: {
    alias: 'w',
    desc: 'Secret to write',
    type: 'string',
    requiresArg: 'KEY'
  },
  value: {
    desc: 'Secret value to write (if omitted, will be prompted for the value)',
    type: 'string',
    requiresArg: 'VALUE'
  },
};

export function handler(args: yargs.Arguments) {
  args.commandHandler = realHandler;
}

export async function realHandler(options: CommandOptions): Promise<number> {
  const stacks = await options.appStacks.selectStacks(...(options.args.STACKS || []));
  const secrets = collectSecrets(stacks);

  // Print config by default
  const data: any[] = [[colors.green('#'), colors.green('Secret'), colors.green('Has Value?'), colors.green('Used')]];
  for (const [i, secret] of secrets) {
    data.push([i, describeSecret(secret.metadata), '*****', secret.paths.join(' ')]);
  }

  print(`Secrets used this app:\n`);

  print(table.table(data, {
      border: table.getBorderCharacters('norc'),
      columns: {
        1: { width: 50, wrapWord: true } as any,
        3: { width: 50, wrapWord: true } as any
      }
  }));

  return 0;
}

type NumberedSecret = [number, Metadata<cxapi.SecretMetadataEntry>];

/**
 * Recurse over all stacks, collect all secret metadata entries and number then
 */
function collectSecrets(stacks: cxapi.SynthesizedStack[]): NumberedSecret[] {
  // Find all referenced secrets in all selected apps
  const secrets = combineMetadataEntries(secretKey, collectMetadataEntries(cxapi.SECRET_METADATA, ...stacks));

  // Filter down to only the ones we know
  const supportedTypes = ['secretsmanager'];
  secrets.filter(s => !supportedTypes.includes(s.metadata.type)).forEach(s => {
    warning(`Unrecognized secret type: ${s.metadata.type}, used at ${s.paths}`);
  });

  const supportedSecrets = secrets.filter(s => supportedTypes.includes(s.metadata.type)) ;

  return enumerate1(supportedSecrets);
}

/*
function keyByNumber(context: any, n: number) {
  for (const [i, key] of contextKeys(context)) {
    if (n === i) {
      return key;
    }
  }
  throw new Error(`No context key with number: ${n}`);
}
*/

function enumerate1<T>(xs: T[]): Array<[number, T]> {
  const ret = new Array<[number, T]>();
  let i = 1;
  for (const x of xs) {
    ret.push([i, x]);
    i += 1;
  }
  return ret;
}

/**
 * Return a unique key string per secret
 */
function secretKey(entry: cxapi.SecretMetadataEntry) {
  return [entry.type, entry.identifier, entry.jsonKey, entry.versionStage, entry.versionId].toString();
}

/**
 * Return a descriptive string per secret
 */
function describeSecret(entry: cxapi.SecretMetadataEntry) {
  const parts = [entry.identifier];
  if (entry.jsonKey) { parts.push(`.${entry.jsonKey}`); }
  if (entry.versionStage) { parts.push(`@${entry.versionStage}`); }
  if (entry.versionId) { parts.push(`@${entry.versionId}`); }
  return parts.join('');
}