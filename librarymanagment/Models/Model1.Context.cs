﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace librarymanagment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class library_managmentEntities5 : DbContext
    {
        public library_managmentEntities5()
            : base("name=library_managmentEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<booksInfo> booksInfoes { get; set; }
        public virtual DbSet<customerInfo> customerInfos { get; set; }
        public virtual DbSet<customerissue> customerissues { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<person_infos> person_infos { get; set; }
    }
}
