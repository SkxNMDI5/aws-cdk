using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.CertificateManager.cloudformation.CertificateResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html </remarks>
    [JsiiInterface(typeof(IDomainValidationOptionProperty), "@aws-cdk/aws-certificatemanager.cloudformation.CertificateResource.DomainValidationOptionProperty")]
    public interface IDomainValidationOptionProperty
    {
        /// <summary>``CertificateResource.DomainValidationOptionProperty.DomainName``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoptions-domainname </remarks>
        [JsiiProperty("domainName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object DomainName
        {
            get;
            set;
        }

        /// <summary>``CertificateResource.DomainValidationOptionProperty.ValidationDomain``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html#cfn-certificatemanager-certificate-domainvalidationoption-validationdomain </remarks>
        [JsiiProperty("validationDomain", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object ValidationDomain
        {
            get;
            set;
        }
    }
}