using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroAcademico.Datos
{
    public class RegistroAcademicoContext : DbContext
    {
        public RegistroAcademicoContext() : base("name=RegistroAcademico")
        {
            Database.SetInitializer(new RegistroAcademicoInitializer());
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
            .HasMany(e => e.Estudiantes)
            .WithRequired(e => e.TipoDocumento)
            .HasForeignKey(e => e.IdTipoDocumento)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciudad>()
            .HasMany(e => e.Estudiantes)
            .WithRequired(e => e.Ciudad)
            .HasForeignKey(e => e.IdCiudad)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departamento>()
            .HasMany(e => e.Estudiantes)
            .WithRequired(e => e.Departamento)
            .HasForeignKey(e => e.IdDepartamento)
            .WillCascadeOnDelete(false);
        }

    }
}