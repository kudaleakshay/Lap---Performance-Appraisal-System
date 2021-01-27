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

    public partial class Report60
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }


        [Required(ErrorMessage = "कृपया कार्यरत अधिकारी संख्या आवश्यक आहे")]
        [DisplayName("अधिकारी संख्या")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Officer_Count { get; set; }


        [Required(ErrorMessage = "कृपया कार्यरत कर्मचारी संख्या आवश्यक आहे")]
        [DisplayName("कर्मचारी संख्या")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Staff_Count { get; set; }


        [Required(ErrorMessage = "कृपया एकुण कार्यरत अधिकारी / कर्मचारी संख्या आवश्यक आहे")]
        [DisplayName("एकुण कार्यरत अधिकारी / कर्मचारी संख्या")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Staff { get; set; }


        [Required(ErrorMessage = "कृपया अधिकारी लक्षांक संख्या आवश्यक आहे")]
        [DisplayName("अधिकारी लक्षांक")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Officer_Target { get; set; }


        [Required(ErrorMessage = "कृपया कर्मचारी लक्षांक संख्या आवश्यक आहे")]
        [DisplayName("कर्मचारी लक्षांक")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Staff_Target { get; set; }


        [Required(ErrorMessage = "कृपया एकुण अधिकारी / कर्मचारी लक्षांक संख्या आवश्यक आहे")]
        [DisplayName("एकुण अधिकारी / कर्मचारी लक्षांक")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Target { get; set; }


        [Required(ErrorMessage = "कृपया चालु महिना अखेर उद्दीष्टे आवश्यक आहे")]
        [DisplayName("चालु महिना अखेर उद्दीष्टे")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Aim { get; set; }



        [Required(ErrorMessage = "कृपया साध्यतेप्रमाणे सहकारी संस्था तपासणी संख्या आवश्यक आहे")]
        [DisplayName("मागील महिना अखेर सहकारी संस्था तपासणी साध्य")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Last_Month_Achieved { get; set; }



        [Required(ErrorMessage = "कृपया साध्यतेप्रमाणे सहकारी संस्था तपासणी संख्या आवश्यक आहे")]
        [DisplayName("चालू महिना अखेर सहकारी संस्था तपासणी साध्य")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Current_Month_Achieved { get; set; }



        [Required(ErrorMessage = "कृपया साध्यतेप्रमाणे एकुण सहकारी संस्था तपासणी संख्या आवश्यक आहे")]
        [DisplayName("एकुण सहकारी संस्था तपासणी साध्य")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "फक्त संख्या प्रविष्ट करा")]
        public Nullable<int> Total_Achieved { get; set; }


        [Required(ErrorMessage = "कृपया टक्केवारी आवश्यक आहे")]
        [DisplayName("चालु महिना अखेर उद्दीष्टांच्या  साध्यतेनुसार टक्केवारी")]
        public Nullable<double> Current_Month_Percentage { get; set; }


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
