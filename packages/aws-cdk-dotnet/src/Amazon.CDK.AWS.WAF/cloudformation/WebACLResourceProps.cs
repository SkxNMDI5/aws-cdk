using Amazon.CDK;
using Amazon.CDK.AWS.WAF.cloudformation.WebACLResource;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.WAF.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html </remarks>
    public class WebACLResourceProps : DeputyBase, IWebACLResourceProps
    {
        /// <summary>``AWS::WAF::WebACL.DefaultAction``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-defaultaction </remarks>
        [JsiiProperty("defaultAction", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-waf.cloudformation.WebACLResource.WafActionProperty\"}]}}", true)]
        public object DefaultAction
        {
            get;
            set;
        }

        /// <summary>``AWS::WAF::WebACL.MetricName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-metricname </remarks>
        [JsiiProperty("metricName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object MetricName
        {
            get;
            set;
        }

        /// <summary>``AWS::WAF::WebACL.Name``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-name </remarks>
        [JsiiProperty("webAclName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object WebAclName
        {
            get;
            set;
        }

        /// <summary>``AWS::WAF::WebACL.Rules``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-rules </remarks>
        [JsiiProperty("rules", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-waf.cloudformation.WebACLResource.ActivatedRuleProperty\"}]}}}}]},\"optional\":true}", true)]
        public object Rules
        {
            get;
            set;
        }
    }
}