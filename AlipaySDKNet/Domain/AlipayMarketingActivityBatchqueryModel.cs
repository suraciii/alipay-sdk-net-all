using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 活动状态  枚举值：   ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。 PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户 限制: 接口调用者必须有商户代运营权限。  代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 分页查询页码。  限制: 必须为大于0的整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
