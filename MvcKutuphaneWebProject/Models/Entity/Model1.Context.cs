﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphaneWebProject.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MvcKutuphaneDbEntities : DbContext
    {
        public MvcKutuphaneDbEntities()
            : base("name=MvcKutuphaneDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblCeza> TblCeza { get; set; }
        public virtual DbSet<TblHareket> TblHareket { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblKategori> TblKategori { get; set; }
        public virtual DbSet<TblKitap> TblKitap { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblUye> TblUye { get; set; }
        public virtual DbSet<TblYazar> TblYazar { get; set; }
    }
}
