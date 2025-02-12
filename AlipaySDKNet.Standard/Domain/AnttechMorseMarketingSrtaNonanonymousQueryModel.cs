using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNonanonymousQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingSrtaNonanonymousQueryModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 手机号 hash后的值；  uid和mobile_sha_256二选一
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// string 必填 调用商户的请求唯一标识，业务唯一标识，最大长度128
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 用户id，可以使用2088账号，可以使用hash后的匿名用户id是； uid和 mobile_sha256二选一
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
