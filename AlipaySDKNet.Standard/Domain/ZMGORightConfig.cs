using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGORightConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGORightConfig : AopObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("custom_benefit_desc")]
        public string CustomBenefitDesc { get; set; }

        /// <summary>
        /// 权益描述子标题
        /// </summary>
        [XmlElement("custom_sub_benefit_desc")]
        public string CustomSubBenefitDesc { get; set; }
    }
}
