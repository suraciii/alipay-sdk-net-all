using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherModifyModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。 不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 引导用户配置。该值为空表示不修改。
        /// </summary>
        [XmlElement("customer_guide")]
        public CustomerGuideModify CustomerGuide { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。该值为空表示不修改  格式为：yyyy-MM-dd HH:mm:ss  限制： 1、券发放结束时间publish_end_time 与 券发放开始时间publish_start_time 间隔必须小于等于180天 2、修改发放结束时间，只能延长，不允许缩短。 3、活动已到期或已停止修改结束时间不会生效
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券展示信息。该值为空表示不修改。
        /// </summary>
        [XmlElement("voucher_display_info")]
        public VoucherDisplayInfoModify VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public VoucherSendRuleDetailModify VoucherSendRule { get; set; }

        /// <summary>
        /// 券使用规则。该值为空表示不修改。
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public VoucherUseRuleModify VoucherUseRule { get; set; }
    }
}
