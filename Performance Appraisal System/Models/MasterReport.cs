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
    
    public partial class MasterReport
    {
        public int Id { get; set; }
        public Nullable<int> UId { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<double> Establishment { get; set; }
        public Nullable<double> Krushipat { get; set; }
        public Nullable<double> IT { get; set; }
        public Nullable<double> Budget { get; set; }
        public Nullable<double> Audit { get; set; }
        public Nullable<double> Law { get; set; }
        public Nullable<double> Housing { get; set; }
        public Nullable<double> Credit_Societies { get; set; }
        public Nullable<double> O_M { get; set; }
        public Nullable<double> Money_Lending { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual User User { get; set; }
    }
}