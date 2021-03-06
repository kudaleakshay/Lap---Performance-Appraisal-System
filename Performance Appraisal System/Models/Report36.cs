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


    public partial class Report36
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }



        [Required(ErrorMessage = "कृपया लेखापरीक्षणास पात्र असणाऱ्या संस्थांपैकी लेखापरीक्षण न झालेल्या एकुण संस्थांची संख्या  आवश्यक आहे")]
        [DisplayName("लेखापरीक्षणास पात्र असणाऱ्या संस्थांपैकी मागील महिनाअखेर मागील आर्थिक वर्षाचे लेखापरीक्षण न झालेल्या एकुण संस्थांची संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Eligible_for_Audit { get; set; }



        [Required(ErrorMessage = "कृपया चालु महिन्यात लेखापरीक्षण पुर्ण झालेल्या संस्थांची संख्या आवश्यक आहे")]
        [DisplayName("चालु महिन्यात लेखापरीक्षण पुर्ण झालेल्या संस्थांची संख्या ")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Audit { get; set; }




        [Required(ErrorMessage = "कृपया चालु महिनाअखेर लेखापरीक्षण पुर्ण न झालेल्या संस्थांची संख्या आवश्यक आहे")]
        [DisplayName("चालु महिनाअखेर लेखापरीक्षण पुर्ण न झालेल्या संस्थांची संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Remaining_for_Audit { get; set; }


        [Required(ErrorMessage = "कृपया कारवाई केल्याची संख्या आवश्यक आहे")]
        [DisplayName("लेखापरीक्षण न होण्यास कारणीभुत असलेल्या संस्था/लेखापरीक्षक यांचेवर कारवाई केल्याची संख्या")]
        public Nullable<int> Action_Taken { get; set; }



        [Required(ErrorMessage = "कृपया कारवाईचे केल्याचे प्रमाण टक्केवारी आवश्यक आहे")]
        [DisplayName("कारवाईचे केल्याचे प्रमाण")]
        public Nullable<double> Percentage_Action_Taken { get; set; }


        

        [Required(ErrorMessage = "कृपया गुणांची संख्या आवश्यक आहे")]
        [DisplayName("कारवाईच्या प्रमाणात मिळालेले गुण")]
        public Nullable<double> Marks_Action_Taken { get; set; }



        [Required(ErrorMessage = "कृपया  प्राप्त गुणांची टक्केवारी आवश्यक आहे")]
        [DisplayName("प्राप्त गुणांची टक्केवारी")]
        public Nullable<double> Appraisal_Percentage { get; set; }



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
