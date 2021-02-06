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

    public partial class Report18
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }



        [Required(ErrorMessage = "कृपया रब्बी कर्ज वाटपाचे लक्षांक संख्या आवश्यक आहे")]
        [DisplayName("वार्षिक रब्बी कर्ज वाटपाचे लक्षांक")]
        public Nullable<double> Loan_Allocation_Target { get; set; }



        [Required(ErrorMessage = "कृपया मागील महिना अखेर कर्जवाटप संख्या आवश्यक आहे")]
        [DisplayName("मागील महिना अखेर कर्जवाटप")]
        public Nullable<double> Last_Month_Loan_Allocation { get; set; }


        [Required(ErrorMessage = "कृपया चालु महिना अखेर कर्जवाटप आवश्यक आहे")]
        [DisplayName("चालु महिना अखेर कर्जवाटप")]
        public Nullable<double> Current_Month_Loan_Allocation { get; set; }



        [Required(ErrorMessage = "कृपया एकुण कर्जवाटप संख्या आवश्यक आहे")]
        [DisplayName("एकुण कर्जवाटप")]
        public Nullable<double> Total_Loan_Allocation { get; set; }


        [Required(ErrorMessage = "कृपया मुल्यांकनानुसार प्राप्त गुण आवश्यक आहे")]
        [DisplayName("मुल्यांकनानुसार एकुण प्राप्त गुण")]
        public Nullable<double> Appraisal_Marks { get; set; }


        [Required(ErrorMessage = "कृपया  प्राप्त गुणांची टक्केवारी आवश्यक आहे")]
        [DisplayName("प्राप्त गुणांची टक्केवारी")]
        public Nullable<double> Appraisal_Percentage { get; set; }

        public bool NotApplicable { get; set; }

        public Nullable<int> Month { get; set; }

        public Nullable<int> Year { get; set; }


        [DisplayName("शेरा")]
        public string Remarks { get; set; } 

		public System.DateTime CreatedTime { get; set; }

        public virtual User User { get; set; }
    }
}
