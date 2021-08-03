using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveService Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveService : AopObject
    {
        /// <summary>
        /// 父服务编码
        /// </summary>
        [XmlElement("ref_serv_code")]
        public string RefServCode { get; set; }

        /// <summary>
        /// 父服务名称
        /// </summary>
        [XmlElement("ref_serv_name")]
        public string RefServName { get; set; }

        /// <summary>
        /// 父服务类型
        /// </summary>
        [XmlElement("ref_serv_type")]
        public string RefServType { get; set; }

        /// <summary>
        /// 服务类目
        /// </summary>
        [XmlElement("serv_cat")]
        public string ServCat { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("serv_code")]
        public string ServCode { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("serv_desc")]
        public string ServDesc { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("serv_id")]
        public string ServId { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [XmlElement("serv_link")]
        public string ServLink { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("serv_logo")]
        public string ServLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("serv_name")]
        public string ServName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("serv_type")]
        public string ServType { get; set; }
    }
}
