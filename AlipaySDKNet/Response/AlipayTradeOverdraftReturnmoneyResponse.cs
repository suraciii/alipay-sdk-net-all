using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOverdraftReturnmoneyResponse.
    /// </summary>
    public class AlipayTradeOverdraftReturnmoneyResponse : AopResponse
    {
        /// <summary>
        /// 退款时上送的外部退款请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 追款收款账户
        /// </summary>
        [XmlElement("receive_account")]
        public string ReceiveAccount { get; set; }

        /// <summary>
        /// 垫资追款结果。枚举值： SUCCESS：追款成功 FAILED：追款失败 PROCESSING：追款中
        /// </summary>
        [XmlElement("return_result")]
        public string ReturnResult { get; set; }

        /// <summary>
        /// 垫付追款完成时间
        /// </summary>
        [XmlElement("success_time")]
        public string SuccessTime { get; set; }
    }
}
