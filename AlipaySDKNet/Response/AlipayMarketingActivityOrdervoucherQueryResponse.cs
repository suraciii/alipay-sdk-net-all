using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。  不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态。  取值范围： 1.CREATING：创建中。 2.MODIFYING：修改中。 3.APPENDING：追加中。 4.FINISHEING：终止中。  限制： 该值为空，说明活动当前没有正在执行中的操作。
        /// </summary>
        [XmlElement("activity_operation_status")]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 活动状态。  取值范围： 1.ACTIVE：已激活（活动正常运行）。 2.FINISHED：已终止（商家终止活动，不可再发放。  限制： 1.该值为空，说明活动还未创建成功。可以使用 activity_operation_status字段判断活动是否处于CREATING状态。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动所属的商户信息。 如果为空.则是因为创建时未传入，默认为活动归属于接口的调用者。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商家券业务标签，影响商家券对C端用户的展示形式。 枚举值 兑换券团购场景 GROUP_BUY_EXCHANGE_VOUCHER 兑换券代金场景 FIX_EXCHANGE_VOUCHER
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 用户引导相关配置
        /// </summary>
        [XmlElement("customer_guide")]
        public CustomerGuide CustomerGuide { get; set; }

        /// <summary>
        /// 券发放结束时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券汇总信息
        /// </summary>
        [XmlElement("summary")]
        public VoucherSummary Summary { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_info")]
        public VoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public VoucherSendRuleDetail VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型。  取值范围： 1.FIX_VOUCHER：满减券。 2.DISCOUNT_VOUCHER：折扣券。 3.SPECIAL_VOUCHER：特价券。 4.EXCHANGE_VOUCHER: 兑换券。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券使用规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public VoucherUseRule VoucherUseRule { get; set; }
    }
}
