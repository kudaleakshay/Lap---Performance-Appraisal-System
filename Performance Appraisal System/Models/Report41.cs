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

    public partial class Report41
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }


        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("अवसायनातील 10 वर्षावरील संस्था रद्द करणे.(वार्षिक लक्षांक)")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Society_Cancellation { get; set; }

        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("मागिल महिना अखेर (साध्य)")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Achieved { get; set; }


        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("चालू महिना अखेर (साध्य)")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Achieved { get; set; }


        [Required(ErrorMessage = "कृपया संख्या आवश्यक आहे")]
        [DisplayName("एकूण साध्य")]
        [RegularExpression("([0-9][0-9]*[.]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Achieved { get; set; }

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
