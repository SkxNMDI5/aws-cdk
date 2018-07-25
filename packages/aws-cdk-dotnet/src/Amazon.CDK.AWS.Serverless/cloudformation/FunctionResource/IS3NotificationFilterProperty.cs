using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.Serverless.cloudformation.FunctionResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html </remarks>
    [JsiiInterface(typeof(IS3NotificationFilterProperty), "@aws-cdk/aws-serverless.cloudformation.FunctionResource.S3NotificationFilterProperty")]
    public interface IS3NotificationFilterProperty
    {
        /// <summary>``FunctionResource.S3NotificationFilterProperty.S3Key``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html </remarks>
        [JsiiProperty("s3Key", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object S3Key
        {
            get;
            set;
        }
    }
}