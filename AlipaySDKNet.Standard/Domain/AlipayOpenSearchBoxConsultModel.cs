using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxConsultModel : AopObject
    {
        /// <summary>
        /// 品牌介绍，5-15个中文字符。  小程序直达不支持设置此项
        /// </summary>
        [XmlElement("box_desc")]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 品牌id，参考<a href="https://opendocs.alipay.com/rules/029uy4">品牌认证说明</a>
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 自定义触发词，最多可配置6个，限1-8个中文字符。  小程序直达不支持设置此项
        /// </summary>
        [XmlArray("custom_keywords")]
        [XmlArrayItem("string")]
        public List<string> CustomKeywords { get; set; }

        /// <summary>
        /// 氛围图片id，调用 <a href="https://opendocs.alipay.com/pre-open/032j4c">支付宝文件上传接口</a> 上传图片获取图片id(bizCode：search_box_atmosphere)。 <a href="https://opendocs.alipay.com/mini/operation/atmospheredesign">图片规范</a>  小程序直达不支持设置此项。
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 氛围图片名。  小程序直达不支持设置此项
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 关联账号信息，1-2个。 内部字段均需设置。
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("search_box_app_info")]
        public List<SearchBoxAppInfo> RelatedAccounts { get; set; }

        /// <summary>
        /// 服务信息，服务必须审核通过才能申请搜索直达。 内部字段均需设置。
        /// </summary>
        [XmlArray("service_infos")]
        [XmlArrayItem("search_box_service_info")]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }

        /// <summary>
        /// 小程序id，小程序直达时必传，需要和申请的商户主体保持一致，且符合<a href="https://opendocs.alipay.com/b/03al6e">准入类目</a>
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
