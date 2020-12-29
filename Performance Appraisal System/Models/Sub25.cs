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

    public partial class Sub25
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }

        [Required(ErrorMessage = "कृपया द्यावयाचे गुण आवश्यक आहे")]
        [DisplayName("द्यावयाचे गुण")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Marks { get; set; }

        [Required(ErrorMessage = "कृपया उद्दिष्ट आवश्यक आहे")]
        [DisplayName("उद्दिष्ट")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Aim { get; set; }

        [Required(ErrorMessage = "कृपया साध्य आवश्यक आहे")]
        [DisplayName("साध्य")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Achieved { get; set; }


        [Required(ErrorMessage = "कृपया मिळालेले गुण आवश्यक आहे")]
        [DisplayName("मिळालेले गुण")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Appraisal_Marks { get; set; }


        [DisplayName("शेरा")]
        public string Remarks { get; set; }


        public Nullable<int> Month { get; set; }

        public Nullable<int> Year { get; set; }



        public virtual User User { get; set; }
    }
}
