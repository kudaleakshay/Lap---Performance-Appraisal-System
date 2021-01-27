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

    public partial class Report29
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }


        [Required(ErrorMessage = "कृपया मागील महिन्यातील शिल्लक तक्रारीची संख्या आवश्यक आहे")]
        [DisplayName("मागील महिन्यातील शिल्लक तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> CM_Last_Month_Pending_Complaints { get; set; }



        [Required(ErrorMessage = "कृपया चालू महिन्यात प्राप्त तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("चालू महिन्यात प्राप्त तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> CM_Current_Month_Received_Complaints { get; set; }


        [Required(ErrorMessage = "कृपया एकुण तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("एकुण तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> CM_Total_Complaints { get; set; }



        [Required(ErrorMessage = "कृपया निकाली काढलेल्या तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("चालू महिन्यातील एकुण निकाली तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> CM_Current_Month_Resolved_Complaints { get; set; }




        [Required(ErrorMessage = "कृपया प्रलंबित तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("२१ दिवसांच्यावर प्रलंबित तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> CM_Pending_Complaints { get; set; }



        [Required(ErrorMessage = "कृपया मागील महिन्यातील शिल्लक तक्रारीची संख्या आवश्यक आहे")]
        [DisplayName("मागील महिन्यातील शिल्लक तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> PM_Last_Month_Pending_Complaints { get; set; }



        [Required(ErrorMessage = "कृपया चालू महिन्यात प्राप्त तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("चालू महिन्यात प्राप्त तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> PM_Current_Month_Received_Complaints { get; set; }


        [Required(ErrorMessage = "कृपया एकुण तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("एकुण तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> PM_Total_Complaints { get; set; }



        [Required(ErrorMessage = "कृपया निकाली काढलेल्या तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("चालू महिन्यातील एकुण निकाली तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> PM_Current_Month_Resolved_Complaints { get; set; }




        [Required(ErrorMessage = "कृपया प्रलंबित तक्रारींची संख्या आवश्यक आहे")]
        [DisplayName("२१ दिवसांच्यावर प्रलंबित तक्रारी")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> PM_Pending_Complaints { get; set; }




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
