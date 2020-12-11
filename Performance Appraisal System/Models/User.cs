﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Performance_Appraisal_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    public partial class User
    {

        public int UId { get; set; }

        [Required(ErrorMessage = "कृपया वापरकर्त्याचे आयडी आवश्यक आहे")]
        [DisplayName("वापरकर्त्याचे आयडी")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "कृपया वापरकर्त्याचे नाव आवश्यक आहे")]
        [DisplayName("वापरकर्त्याचे नाव")]
        public string Name { get; set; }

        [Required(ErrorMessage = "कृपया पासवर्ड आवश्यक आहे")]
        [DisplayName("पासवर्ड")]
        public string Password { get; set; }

        [DisplayName("ई-मेल")]
        [EmailAddress(ErrorMessage = "ई-मेल वैध नाही")]
        public string Email { get; set; }

        /*[Required(ErrorMessage = "Division can't be blank")]*/
        [DisplayName("विभाग")]
        public Nullable<int> DivisionId { get; set; }

        /*[Required(ErrorMessage = "District can't be blank")]*/
        [DisplayName("जिल्हा")]
        public Nullable<int> DistrictId { get; set; }

        [Required(ErrorMessage = "कृपया पदनाम आवश्यक आहे")]
        [DisplayName("पदनाम")]
        public Nullable<int> RoleId { get; set; }

        /*[Required(ErrorMessage = "Status can't be blank")]*/
        [DisplayName("स्थिती")]
        public Nullable<int> Status { get; set; }

        /*[Required(ErrorMessage = "Reporting officer can't be blank")]*/
        [DisplayName("उच्च अधिकारी")]
        public Nullable<int> ReportTo { get; set; }

        public Nullable<int> AppraisalType { get; set; }

        public virtual District District { get; set; }


        public virtual Division Division { get; set; }


        public virtual Role Role { get; set; }
    }
}
