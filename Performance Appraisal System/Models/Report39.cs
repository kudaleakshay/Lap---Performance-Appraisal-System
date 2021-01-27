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


    public partial class Report39
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }

        [Required(ErrorMessage = "कृपया मागील आर्थिक वर्षातील दुरुस्ती अहवाल संख्या आवश्यक आहे")]
        [DisplayName("मागील आर्थिक वर्षातील दुरुस्ती अहवाल संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Year_Remaining { get; set; }



        [Required(ErrorMessage = "कृपया चालु आर्थिक वर्षातील दुरुस्ती अहवाल संख्या आवश्यक आहे")]
        [DisplayName("चालु आर्थिक वर्षातील दुरुस्ती अहवाल संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Year_Remaining { get; set; }



        [Required(ErrorMessage = "कृपया एकुण दुरुस्ती अहवाल संख्या आवश्यक आहे")]
        [DisplayName("एकुण दुरुस्ती अहवाल संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Remaining { get; set; }



        [Required(ErrorMessage = "कृपया निबंधकाने कारवाई केलेली संख्या आवश्यक आहे")]
        [DisplayName("निबंधकाने कारवाई केलेली संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Action_Taken { get; set; }


        [Required(ErrorMessage = "कृपया कारवाईचे प्रमाण टक्केवारी आवश्यक आहे")]
        [DisplayName("कारवाईचे प्रमाण")]
        public Nullable<double> Percentage_Action_Taken { get; set; }



        [Required(ErrorMessage = "कृपया मुल्यांकनानुसार प्राप्त गुण आवश्यक आहे")]
        [DisplayName("मुल्यांकनानुसार एकुण प्राप्त गुण")]
        public Nullable<double> Appraisal_Marks { get; set; }

        public bool NotApplicable { get; set; }

        public Nullable<int> Month { get; set; }

        public Nullable<int> Year { get; set; }


        [DisplayName("शेरा")]
        public string Remarks { get; set; } 

		public System.DateTime CreatedTime { get; set; }

        public virtual User User { get; set; }
    }
}
