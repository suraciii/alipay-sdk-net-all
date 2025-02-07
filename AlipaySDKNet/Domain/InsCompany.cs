using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCompany Data Structure.
    /// </summary>
    [Serializable]
    public class InsCompany : AopObject
    {
        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [XmlElement("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 商户/企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 渠道用户ID
        /// </summary>
        [XmlElement("channel_account_id")]
        public string ChannelAccountId { get; set; }

        /// <summary>
        /// 渠道用户类型
        /// </summary>
        [XmlElement("channel_account_type")]
        public string ChannelAccountType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
