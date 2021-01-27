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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Report47
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("मागील महिना अखेर प्राप्त")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Received_Cases { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("चालु महिन्यातील प्राप्त")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Received_Cases { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("एकूण प्रकरणे")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Cases { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("निकाली काढावायाची एकूण प्रकरणांपैकी लक्षांक")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Target { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("लक्षांक पूर्तता")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Achieved { get; set; }



        [Required(ErrorMessage = "कृपया मुल्यांकनानुसार प्राप्त गुण आवश्यक आहे")]
        [DisplayName("मुल्यांकनानुसार एकुण प्राप्त गुण")]
        public Nullable<double> Appraisal_Marks { get; set; }


        [Required(ErrorMessage = "कृपया  प्राप्त गुणांची टक्केवारी आवश्यक आहे")]
        [DisplayName("प्राप्त गुणांची टक्केवारी")]
        public Nullable<double> Appraisal_Percentage { get; set; }
        public bool NotApplicable { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public string Remarks { get; set; } 

		public System.DateTime CreatedTime { get; set; }

        public virtual User User { get; set; }
    }
}
