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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Performance_Appraisal_System.Models;
    
    public partial class DocPASEntities : DbContext
    {
        public DocPASEntities()
            : base("name=DocPASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppraisalTable> AppraisalTables { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Sub60> Sub60 { get; set; }
        public virtual DbSet<Sub24> Sub24 { get; set; }
        public virtual DbSet<Sub25> Sub25 { get; set; }
        public virtual DbSet<Sub26> Sub26 { get; set; }
        public virtual DbSet<Sub27> Sub27 { get; set; }
        public virtual DbSet<Sub28> Sub28 { get; set; }
    }
}
