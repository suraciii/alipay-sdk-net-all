using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyTradeRefundModel : AopObject
    {
        /// <summary>
        /// 退款请求号。标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。运营机构会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 调用方订单号。由调用方(商户或者收单受理机构)定义，64个字符以内，仅支持字母、数字、下划线且需保证在调用方不重复。 out_trade_no与trade_no二选一 用于幂等
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额。需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因说明，商家自定义。
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 运营机构交易号。和商户订单号 out_trade_no 不能同时为空。 out_trade_no与trade_no二选一
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
