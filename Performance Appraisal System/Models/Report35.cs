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

    public partial class Report35
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }



        [Required(ErrorMessage = "कृपया निश्चित केलेली लक्षांक संख्या आवश्यक आहे")]
        [DisplayName("चालु आर्थिक वर्षासाठी निश्चित केलेला वार्षिक लक्षांक")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Target { get; set; }



        [Required(ErrorMessage = "कृपया मागील महिनाअखेर लेखापरीक्षण पुर्ण केलेल्या संस्थांची संख्या आवश्यक आहे")]
        [DisplayName("मागील महिनाअखेर लेखापरीक्षण पुर्ण केलेल्या संस्थांची संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Achieved { get; set; }



        [Required(ErrorMessage = "कृपया चालु महिन्यात लेखापरीक्षण पुर्ण केलेली संस्थांची संख्या आवश्यक आहे")]
        [DisplayName("चालु महिन्यात लेखापरीक्षण पुर्ण केलेली संस्थांची संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Achieved { get; set; }


        [Required(ErrorMessage = "कृपया पुर्ण केलेल्या एकुण संस्थांची संख्या आवश्यक आहे")]
        [DisplayName("पुर्ण केलेल्या एकुण संस्थांची संख्या")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Achieved { get; set; }


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