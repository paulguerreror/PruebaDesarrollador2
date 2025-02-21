using Microsoft.EntityFrameworkCore;
using PruebaDesarrollador.Models;

namespace PruebaDesarrollador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(p => p.NumeroIdentificacionCompleto)
                .HasComputedColumnSql("[TipoIdentificacion] + '-' + [NumeroIdentificacion]");

            modelBuilder.Entity<Persona>()
                .Property(p => p.NombreCompleto)
                .HasComputedColumnSql("[Nombres] + ' ' + [Apellidos]");
        }
    }
}
