﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAC_Acceso_Datos_10
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using GAC_Entidades_10;
    
    public partial class BusesEntities : DbContext
    {
        public BusesEntities()
            : base("name=BusesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ayudante> ayudante { get; set; }
        public virtual DbSet<boleto> boleto { get; set; }
        public virtual DbSet<bus> bus { get; set; }
        public virtual DbSet<operador> operador { get; set; }
        public virtual DbSet<pasajero> pasajero { get; set; }
        public virtual DbSet<rutas> rutas { get; set; }
        public virtual DbSet<sexo> sexo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipos> tipos { get; set; }
        public virtual DbSet<vendedor> vendedor { get; set; }
    }
}