using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectBenefitPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectBenefitPersonInfo : AopObject
    {
        /// <summary>
        /// 证件反面照（只有身份证类型需要上传反面，使用图片上传接口）
        /// </summary>
        [XmlElement("card_back_img")]
        public string CardBackImg { get; set; }

        /// <summary>
        /// 证件正面照（使用图片上传接口）
        /// </summary>
        [XmlElement("card_front_img")]
        public string CardFrontImg { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 证件类型，枚举值：中国大陆居民-身份证(RESIDENT)、其他国家或地区居民-护照(PASSPORT)、中国港澳居民-来往内地通行证(PASSPORT_HK_MO)、中国台湾居民-来往大陆通行证(PASSPORT_TWN)、个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关、小微商户仅支持身份证类型。
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 证件生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 证件过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 受益人姓名
        /// </summary>
        [XmlElement("person_name")]
        public string PersonName { get; set; }
    }
}
