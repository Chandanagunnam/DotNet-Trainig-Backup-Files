﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LayoutAuthentication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbmovieEntities1 : DbContext
    {
        public dbmovieEntities1()
            : base("name=dbmovieEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<moviebooking> moviebookings { get; set; }
        public virtual DbSet<tblcustomer> tblcustomers { get; set; }
        public virtual DbSet<tblmovie> tblmovies { get; set; }
        public virtual DbSet<tblscreen> tblscreens { get; set; }
        public virtual DbSet<tbltheatre> tbltheatres { get; set; }
    }
}
