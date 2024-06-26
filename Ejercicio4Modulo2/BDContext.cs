using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio4Modulo2
{
    public class BDContext : DbContext
    {
        #region PUNTO 1
        public DbSet<VentasMensuales> VentasMensuales { get; set; }
        public DbSet<Parametria> Parametria { get; set; }
        public DbSet<Rechazos> Rechazos { get; set; }
        public BDContext(DbContextOptions<BDContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VentasMensuales>().ToTable("ventas_mensuales");
            modelBuilder.Entity<Parametria>().ToTable("parametria");
            modelBuilder.Entity<Rechazos>().ToTable("rechazos");


            modelBuilder.Entity<VentasMensuales>().Property(prop => prop.Id).HasColumnName("id");
            modelBuilder.Entity<VentasMensuales>().Property(prop => prop.FechaInforme).HasColumnName("fecha");
            modelBuilder.Entity<VentasMensuales>().Property(prop => prop.CodVendedor).HasColumnName("cod_vendedor");
            modelBuilder.Entity<VentasMensuales>().Property(prop => prop.Venta).HasColumnName("venta");
            modelBuilder.Entity<VentasMensuales>().Property(prop => prop.VentaEmpresaGrande).HasColumnName("venta_empresa_grande"); 

            modelBuilder.Entity<Parametria>().Property(prop => prop.Id).HasColumnName("id");
            modelBuilder.Entity<Parametria>().Property(prop => prop.Key).HasColumnName("key");
            modelBuilder.Entity<Parametria>().Property(prop => prop.Value).HasColumnName("value");

            modelBuilder.Entity<Rechazos>().Property(prop => prop.Id).HasColumnName("id");
            modelBuilder.Entity<Rechazos>().Property(prop => prop.Error).HasColumnName("error");
            modelBuilder.Entity<Rechazos>().Property(prop => prop.RegistroOriginal).HasColumnName("registro_original");

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}