﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTO_FINAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbventasEntities1 : DbContext
    {
        public dbventasEntities1()
            : base("name=dbventasEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<domicilio> domicilio { get; set; }
        public virtual DbSet<ingreso> ingreso { get; set; }
        public virtual DbSet<persona> persona { get; set; }
        public virtual DbSet<venta> venta { get; set; }
    }
}
