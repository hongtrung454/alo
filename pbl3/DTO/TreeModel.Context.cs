﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl3.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HoTroCayXanhEntities : DbContext
    {
        public HoTroCayXanhEntities()
            : base("name=HoTroCayXanhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Planting> Plantings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tree> Trees { get; set; }
        public virtual DbSet<TreeDemand> TreeDemands { get; set; }
        public virtual DbSet<TreeLocation> TreeLocations { get; set; }
        public virtual DbSet<TreeType> TreeTypes { get; set; }
        public virtual DbSet<UserLocation> UserLocations { get; set; }
    }
}
