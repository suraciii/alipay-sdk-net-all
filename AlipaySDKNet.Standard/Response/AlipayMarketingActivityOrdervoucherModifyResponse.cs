using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherModifyResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherModifyResponse : AopResponse
    {
        /// <summary>
        /// 核销规则请求结果
        /// </summary>
        [XmlElement("voucher_use_rule_result")]
        public OrderVoucherUseRuleResult VoucherUseRuleResult { get; set; }
    }
}
