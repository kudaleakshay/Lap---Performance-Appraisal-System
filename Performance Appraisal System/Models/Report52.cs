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

    public partial class Report52
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }

        [Required(ErrorMessage = "कृपया मागील महा अखेर प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("दि.1.4.2020 रोजीची / मागील महा अखेर प्रकरणे")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Pending_Cases { get; set; }


        [Required(ErrorMessage = "कृपया चालु महिन्यातील प्राप्त प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("चालु महिन्यातील प्राप्त प्रकरणे")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Received_Cases { get; set; }


        [Required(ErrorMessage = "कृपया एकुण प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("एकुण प्रकरणे(3+4)")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Cases { get; set; }



        [Required(ErrorMessage = "कृपया उद्दिष्टाप्रमाणे प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("उद्दिष्टाप्रमाणे मागील महा अखेरील प्रकरणे")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Cases_Aim { get; set; }



        [Required(ErrorMessage = "कृपया उद्दिष्टाप्रमाणे प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("उद्दिष्टाप्रमाणे चालु महिन्यातील प्रकरणे")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Cases_Aim { get; set; }



        [Required(ErrorMessage = "कृपया उद्दिष्टाप्रमाणे एकुण प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("उद्दिष्टाप्रमाणे एकुण प्रकरणे (7+8)")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Cases_Aim { get; set; }



        
        [Required(ErrorMessage = "कृपया उद्दिष्ट पूर्ती केलेल्या प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("मागील महा अखेरील")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Achieved { get; set; }



        


        [Required(ErrorMessage = "कृपया उद्दिष्ट पूर्ती केलेल्या प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("चालु महा अखेरील उद्दिष्ट पूर्ती ")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Achieved { get; set; }



        [Required(ErrorMessage = "कृपया एकुण उद्दिष्ट पूर्ती केलेल्या प्रकरणांची संख्या आवश्यक आहे")]
        [DisplayName("एकुण उद्दिष्ट पूर्ती")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Achieved { get; set; }


        [Required(ErrorMessage = "कृपया मुल्यांकनानुसार प्राप्त गुण आवश्यक आहे")]
        [DisplayName("मुल्यांकनानुसार एकुण प्राप्त गुण")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<double> Appraisal_Marks { get; set; }


        [Required(ErrorMessage = "कृपया  प्राप्त गुणांची टक्केवारी आवश्यक आहे")]
        [DisplayName("प्राप्त गुणांची टक्केवारी")]
        public Nullable<double> Appraisal_Percentage { get; set; }

        public bool NotApplicable { get; set; }

        public Nullable<int> Month { get; set; }

        public Nullable<int> Year { get; set; }


        [DisplayName("शेरा")]
        public string Remarks { get; set; }

        public virtual User User { get; set; }
    }
}
