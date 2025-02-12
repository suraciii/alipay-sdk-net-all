using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftSimplecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftSimplecreateModel : AopObject
    {
        /// <summary>
        /// 补充证件图片，与additional_cert_no、additional_cert_type同时提供。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("additional_cert_image")]
        public string AdditionalCertImage { get; set; }

        /// <summary>
        /// 补充证件号，与additional_cert_type+additional_cert_image同时提供。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_no")]
        public string AdditionalCertNo { get; set; }

        /// <summary>
        /// 补充证件类型，与additional_cert_no+additional_cert_image同时提供。可选值有201（营业执照号）、204（民办非企业登记证书）、206（社会团体法人登记证书）、218（事业单位法人证书）、219（党政机关批准设立文件/行政执法主体资格证）。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_type")]
        public string AdditionalCertType { get; set; }

        /// <summary>
        /// 商户别名。支付宝收银台及账单中的商户名称会展示此处设置的别名。如果涉及支付宝APP内的支付，支付结果页也会展示该别名；如果涉及当面付场景，请填写线下店铺名称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结算支付宝账号，结算账号使用支付宝账号时必填。本字段要求与商户名称name同名，且是实名认证支付宝账户(个体工商户可以与name或cert_name相同)
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 签约支付宝账户，用于协议确认，及后续二级商户增值产品服务签约时使用。本字段要求与商户名称name同名(个体工商户可以与name或cert_name相同)，且是实名认证支付宝账户
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 结算银行卡信息，如果结算到支付宝账号，则不需要填写。本业务当前只允许传入一张结算卡。个人类型商户不允许结算到银行卡
        /// </summary>
        [XmlElement("biz_cards")]
        public SettleCardInfo BizCards { get; set; }

        /// <summary>
        /// 经营地址。使用当面付服务时必填。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 商户联系人信息。在本业务中，ContactInfo对象中联系人姓名、手机号必填，其他选填
        /// </summary>
        [XmlElement("contact_infos")]
        public ContactInfo ContactInfos { get; set; }

        /// <summary>
        /// 默认结算规则。当调用收单接口，结算条款中设置默认结算规则时，交易资金将结算至此处设置的默认结算目标账户中。其详细描述及收单接口传参示例参考功能包文档
        /// </summary>
        [XmlElement("default_settle_rule")]
        public DefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 内景照，使用当面付服务时必填。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("in_door_images")]
        public string InDoorImages { get; set; }

        /// <summary>
        /// 开票资料信息
        /// </summary>
        [XmlElement("invoice_info")]
        public MerchantInvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 授权函。当商户名与结算卡户名不一致（模板参考https://gw.alipayobjects.com/os/skylark-tools/public/files/d5fcbe7463d7159a0d362da417d157ed.docx），或涉及外籍法人（这种情况上传任意能证明身份的图片）时必填，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 商户类别码mcc，参见https://gw.alipayobjects.com/os/bmw-prod/e5dbb27b-1d8d-442e-be9e-6e52971ce7c3.xlsx 特殊行业要按照MCC说明中的资质一栏上传辅助资质，辅助资质在qualifications字段中上传，会有人工审核
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 门头照，使用当面付服务时必填。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [XmlElement("out_door_images")]
        public string OutDoorImages { get; set; }

        /// <summary>
        /// 商户行业资质图片，当商户是特殊行业时必填。每项行业资质信息中，industry_qualification_type和industry_qualification_image均必填。
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 商户签约服务，可选值有：当面付、app支付、wap支付、电脑支付、线上资金预授权、新当面资金授权、商户代扣、小程序支付。其值会影响其他字段必填性，详见其他字段描述
        /// </summary>
        [XmlArray("service")]
        [XmlArrayItem("string")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 二级商户与服务商的签约时间。
        /// </summary>
        [XmlElement("sign_time_with_isv")]
        public string SignTimeWithIsv { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序站点。使用电脑支付或wap支付服务时，必须填充一个类型为01(网站)的SiteInfo对象，site_type/site_url/site_name必填；使用app支付服务时，必须填充类型为02(APP)或06(支付宝小程序)的SiteInfo对象，site_type/site_name必填
        /// </summary>
        [XmlElement("sites")]
        public SiteInfo Sites { get; set; }
    }
}
