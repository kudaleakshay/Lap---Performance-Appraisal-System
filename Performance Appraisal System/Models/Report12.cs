//------------------------------------------------------------------------------
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
    
    public partial class Report12
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }
        public Nullable<int> Officer_Count { get; set; }
        public Nullable<int> Retired_Officer_Count { get; set; }
        public Nullable<int> Retirement_Benefits_Target { get; set; }
        public Nullable<int> Retirement_Benefits_Achieved { get; set; }
        public Nullable<int> Retirement_Benefits_Pendig { get; set; }
        public Nullable<double> Appraisal_Marks { get; set; }
        public Nullable<double> Appraisal_Percentage { get; set; }
        public bool NotApplicable { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public string Remarks { get; set; }
    
        public virtual User User { get; set; }
    }
}
