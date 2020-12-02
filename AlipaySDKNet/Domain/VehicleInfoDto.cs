using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleInfoDto : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 认证结果：true、false
        /// </summary>
        [XmlElement("cert_result")]
        public string CertResult { get; set; }

        /// <summary>
        /// 认证级别： V0-未认证、V1-已认证、V2-本
        /// </summary>
        [XmlElement("certification")]
        public string Certification { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 所有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 注册日期，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 使用性质：F-非营运、H-货运、K-客运、Z-租赁、J-教练、O-其他
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 车辆类型：Car-小型汽车、E-Car-新能源小型汽车、Veh-大型汽车、E-Veh-新能源大型汽车、Motor-两三轮摩托车、Van-货车、Other-其他
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别代码
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
