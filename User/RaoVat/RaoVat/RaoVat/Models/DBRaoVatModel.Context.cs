﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaoVat.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBRaoVatEntities : DbContext
    {
        public DBRaoVatEntities()
            : base("name=DBRaoVatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<CHECK> CHECKs { get; set; }
        public virtual DbSet<HINHTHUC> HINHTHUCs { get; set; }
        public virtual DbSet<LOAITIN> LOAITINs { get; set; }
        public virtual DbSet<RAOVAT> RAOVATs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TINHTHANHPHO> TINHTHANHPHOes { get; set; }
        public virtual DbSet<TINHTRANG> TINHTRANGs { get; set; }
        public virtual DbSet<TRANGTHAI> TRANGTHAIs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<ADMIN> ADMINs { get; set; }
    }
}
