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
    
    public partial class Sub28
    {
        public int RId { get; set; }
        public Nullable<int> UId { get; set; }
        public Nullable<int> Marks { get; set; }
        public Nullable<int> Aim { get; set; }
        public Nullable<int> Achieved { get; set; }
        public Nullable<int> Appraisal_Marks { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
    
        public virtual User User { get; set; }
    }
}
