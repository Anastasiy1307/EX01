﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PEEntities2 : DbContext
    {
        private static PEEntities2 _govno;

        public PEEntities2()
            : base("name=PEEntities2")
        {
        }

        public static PEEntities2 GetContext()
        { 
            if(_govno == null) _govno= new PEEntities2();
            return _govno;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Group_p> Group_p { get; set; }
        public virtual DbSet<Instruktor> Instruktor { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Pol> Pol { get; set; }
        public virtual DbSet<Kod_podrazdel> Kod_podrazdel { get; set; }
    }
}