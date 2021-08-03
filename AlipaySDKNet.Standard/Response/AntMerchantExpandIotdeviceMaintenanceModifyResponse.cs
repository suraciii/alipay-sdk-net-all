using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceMaintenanceModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceMaintenanceModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务处理订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
