using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherAvailableShopModify Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherAvailableShopModify : AopObject
    {
        /// <summary>
        /// 商户全部门店可用。 限制： 1、创建活动时传入了该值修改才会生效。
        /// </summary>
        [XmlElement("order_voucher_merchant_all_shop")]
        public OrderVoucherMerchantAllShopModify OrderVoucherMerchantAllShop { get; set; }

        /// <summary>
        /// 券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id 限制： 1、创建活动时传入了该值修改才会生效 2、real_shop_ids中的门店id必须是商业关系门店id。 3、real_shop_ids如果包含重复的门店id会自动进行去重操作。
        /// </summary>
        [XmlArray("real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。 限制： 1、创建活动时传入了该值修改才会生效。 2、shop_ids中的门店id必须是支付宝门店id。 3、shop_ids如果包含重复的门店id会自动进行去重操作。
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
