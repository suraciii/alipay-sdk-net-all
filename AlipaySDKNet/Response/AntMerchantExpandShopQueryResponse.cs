using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopQueryResponse.
    /// </summary>
    public class AntMerchantExpandShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("shop_business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片url。返回值为一个有访问时限的链接
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，值为营业执照或统一社会信用代码证上的名称。
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。
        /// </summary>
        [XmlArray("ext_infos")]
        [XmlArrayItem("shop_ext_info")]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        ///  商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。若未传入shop_id 则本参数与store_id均必填。
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。返回值为一个有访问时限的链接
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原shop_category映射关系参见文档https://ur.alipay.com/3oJ26c0veETkLXgTbtQnYY
        /// </summary>
        [XmlElement("new_shop_category")]
        public string NewShopCategory { get; set; }

        /// <summary>
        /// 门头照，返回值为一个有访问时限的链接
        /// </summary>
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。传入本参数后可不填 store_id 及 ip_role_id。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费（01=已认证，02=待优化，99=未知）
        /// </summary>
        [XmlElement("shop_info_status")]
        public string ShopInfoStatus { get; set; }

        /// <summary>
        /// 店铺名称。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
