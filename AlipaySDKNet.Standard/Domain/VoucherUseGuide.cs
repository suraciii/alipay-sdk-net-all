using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseGuide Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseGuide : AopObject
    {
        /// <summary>
        /// 券可用的小程序appId，卡包详情页可跳转到该appId 限制： 该appId归属的pid必须和当前商户存在同mid关系或跨mid的授权关系。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 1、只有mini_app_id有值时该值传入才会有效 2、该小程序路径是相对路径。详情参考小程序scheme链接介绍https://opendocs.alipay.com/support/01rb18。 3.service_codes与mini_app_path只能二选一或者都不填写。
        /// </summary>
        [XmlElement("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 小程序核销。 说明： 1、该字段为true。则卡包会展示小程序核销按钮跳转至小程序。 2、offline_code_use_guide 与 mini_app_use_guide至少2选1。3、该字段为true，则下面的mini_app_id字段必须填写。
        /// </summary>
        [XmlElement("mini_app_use_guide")]
        public bool MiniAppUseGuide { get; set; }

        /// <summary>
        /// 线下扫码核销。 说明： 1、该字段为true。则卡包会展示相应券码信息。 2、offline_code_use_guide 与 mini_app_use_guide至少2选1
        /// </summary>
        [XmlElement("offline_code_use_guide")]
        public bool OfflineCodeUseGuide { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes与mini_app_path只能二选一或者都不填写。
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }
    }
}
