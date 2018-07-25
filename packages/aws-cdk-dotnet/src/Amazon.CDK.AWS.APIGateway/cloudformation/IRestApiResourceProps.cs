using Amazon.CDK;
using Amazon.CDK.AWS.APIGateway.cloudformation.RestApiResource;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.APIGateway.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html </remarks>
    [JsiiInterface(typeof(IRestApiResourceProps), "@aws-cdk/aws-apigateway.cloudformation.RestApiResourceProps")]
    public interface IRestApiResourceProps
    {
        /// <summary>``AWS::ApiGateway::RestApi.ApiKeySourceType``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-apikeysourcetype </remarks>
        [JsiiProperty("apiKeySourceType", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ApiKeySourceType
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.BinaryMediaTypes``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-binarymediatypes </remarks>
        [JsiiProperty("binaryMediaTypes", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        object BinaryMediaTypes
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.Body``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-body </remarks>
        [JsiiProperty("body", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Body
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.BodyS3Location``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-bodys3location </remarks>
        [JsiiProperty("bodyS3Location", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-apigateway.cloudformation.RestApiResource.S3LocationProperty\"}]},\"optional\":true}")]
        object BodyS3Location
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.CloneFrom``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-clonefrom </remarks>
        [JsiiProperty("cloneFrom", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object CloneFrom
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.Description``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-description </remarks>
        [JsiiProperty("description", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Description
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.EndpointConfiguration``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-endpointconfiguration </remarks>
        [JsiiProperty("endpointConfiguration", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-apigateway.cloudformation.RestApiResource.EndpointConfigurationProperty\"}]},\"optional\":true}")]
        object EndpointConfiguration
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.FailOnWarnings``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-failonwarnings </remarks>
        [JsiiProperty("failOnWarnings", "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object FailOnWarnings
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.MinimumCompressionSize``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-minimumcompressionsize </remarks>
        [JsiiProperty("minimumCompressionSize", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object MinimumCompressionSize
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-name </remarks>
        [JsiiProperty("restApiName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object RestApiName
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.Parameters``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-parameters </remarks>
        [JsiiProperty("parameters", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        object Parameters
        {
            get;
            set;
        }

        /// <summary>``AWS::ApiGateway::RestApi.Policy``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-policy </remarks>
        [JsiiProperty("policy", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Policy
        {
            get;
            set;
        }
    }
}