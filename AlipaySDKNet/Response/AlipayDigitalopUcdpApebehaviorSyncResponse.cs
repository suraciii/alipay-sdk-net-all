using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApebehaviorSyncResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApebehaviorSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求链路标识，用于排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
