﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeoQuiz.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeoQuiz_Entities : DbContext
    {
        public LeoQuiz_Entities()
            : base("name=LeoQuiz_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Test> tblTest { get; set; }
        public virtual DbSet<TestAnswer> tblTestAnswer { get; set; }
        public virtual DbSet<TestingResult> tblTestingResult { get; set; }
        public virtual DbSet<TestingResultAnswer> tblTestingResultAnswer { get; set; }
        public virtual DbSet<TestingURL> tblTestingURL { get; set; }
        public virtual DbSet<TestQuestion> tblTestQuestion { get; set; }
        public virtual DbSet<User> tblUser { get; set; }
    }
}
