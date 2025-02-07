using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardcontentPublishModel : AopObject
    {
        /// <summary>
        /// 生活号+号ID。如果发送类型=自研/三方发送，不要传入；发送类型=mcn发送，请传入public_id【mcn机构绑定达人号ID】
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("source_author")]
        public string SourceAuthor { get; set; }

        /// <summary>
        /// 内容正文。类型为短图文/视频，正文必须填写，理解为短图文/视频的文本部分，仅支持纯文本
        /// </summary>
        [XmlElement("source_content")]
        public string SourceContent { get; set; }

        /// <summary>
        /// 来源文章的原始链接地址
        /// </summary>
        [XmlElement("source_link")]
        public string SourceLink { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [XmlArray("source_media_infos")]
        [XmlArrayItem("source_media_info")]
        public List<SourceMediaInfo> SourceMediaInfos { get; set; }

        /// <summary>
        /// 关联服务,目前只支持一个，offerId为关联的服务ID，目前只支持小程序，offerId为小程序ID，offerType为 mini_app
        /// </summary>
        [XmlArray("source_offers")]
        [XmlArrayItem("source_offer")]
        public List<SourceOffer> SourceOffers { get; set; }

        /// <summary>
        /// 文章发布时间 仅支持 yyyy-MM-dd HH:mm:ss 格式
        /// </summary>
        [XmlElement("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// 文章的摘要
        /// </summary>
        [XmlElement("source_summary")]
        public string SourceSummary { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("source_title")]
        public string SourceTitle { get; set; }

        /// <summary>
        /// 内容类型（1、短图文；2、视频）
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
