using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileQueryResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofileQueryResponse : AopResponse
    {
        /// <summary>
        /// 宠物资料是否齐全 0 不齐全 1 齐全
        /// </summary>
        [XmlElement("doc_complete")]
        public long DocComplete { get; set; }

        /// <summary>
        /// 档案状态，0 档案创建 1 档案暂存
        /// </summary>
        [XmlElement("doc_status")]
        public long DocStatus { get; set; }

        /// <summary>
        /// 身份证号码,全局唯一
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 鼻纹ID
        /// </summary>
        [XmlElement("nose_print_id")]
        public string NosePrintId { get; set; }

        /// <summary>
        /// 鼻纹更新时间
        /// </summary>
        [XmlElement("nose_print_last_upload_time")]
        public string NosePrintLastUploadTime { get; set; }

        /// <summary>
        /// 宠物生日，年-月-日
        /// </summary>
        [XmlElement("pet_birthday")]
        public string PetBirthday { get; set; }

        /// <summary>
        /// 宠物是否可编辑
        /// </summary>
        [XmlElement("pet_edit")]
        public bool PetEdit { get; set; }

        /// <summary>
        /// 宠物性别：1公 2 母
        /// </summary>
        [XmlElement("pet_gender")]
        public string PetGender { get; set; }

        /// <summary>
        /// 宠物ID
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 宠物昵称
        /// </summary>
        [XmlElement("pet_nick")]
        public string PetNick { get; set; }

        /// <summary>
        /// 是否绝育
        /// </summary>
        [XmlElement("pet_no_baby")]
        public string PetNoBaby { get; set; }

        /// <summary>
        /// 宠物图片列表
        /// </summary>
        [XmlArray("pet_pic_param_list")]
        [XmlArrayItem("pet_pic_data")]
        public List<PetPicData> PetPicParamList { get; set; }

        /// <summary>
        /// 宠物种类:code编码，阿拉斯加犬等
        /// </summary>
        [XmlElement("pet_species")]
        public string PetSpecies { get; set; }

        /// <summary>
        /// 宠物种类:code编码，阿拉斯加犬等
        /// </summary>
        [XmlElement("pet_species_code")]
        public string PetSpeciesCode { get; set; }

        /// <summary>
        /// 宠物类别:code编码, 1000/2000等
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }

        /// <summary>
        /// 保单类型
        /// </summary>
        [XmlElement("policy_status")]
        public long PolicyStatus { get; set; }
    }
}
