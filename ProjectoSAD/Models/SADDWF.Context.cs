﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectoSAD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SadDWFContainer : DbContext
    {
        public SadDWFContainer()
            : base("name=SadDWFContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student_Atributes> Student_AtributesSet { get; set; }
        public virtual DbSet<Atributes> AtributesSet { get; set; }
        public virtual DbSet<Projects> ProjectsSet { get; set; }
        public virtual DbSet<Student> StudentSet { get; set; }
    }
}
