using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppChargerGreenenergyPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppChargerGreenenergyPublishModel : AopObject
    {
        /// <summary>
        /// 充电单据信息
        /// </summary>
        [XmlElement("charge_order_info")]
        public ChargeOrderInfo ChargeOrderInfo { get; set; }

        /// <summary>
        /// 充电度数，单位 瓦时，即度*1000，如果电量为12.34度则填写12340
        /// </summary>
        [XmlElement("charge_power")]
        public long ChargePower { get; set; }

        /// <summary>
        /// 运营商组织机构代码
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 订单类型：ENERGY_TYPE(能量订单)
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 充电订单号，用于幂等控制，一笔外部充电订单号只可消费一次
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付模式 prePaidModel  预充值  creditPayModel  先充后付
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 支付宝支付交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
