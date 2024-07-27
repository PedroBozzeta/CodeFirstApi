using Microsoft.EntityFrameworkCore;

namespace Codefirst.DB
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions<PruebaContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        // Se sobreescribe el nombre con el que se crean las tablas para que aoarezcan en singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().ToTable("Persona");

            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}
