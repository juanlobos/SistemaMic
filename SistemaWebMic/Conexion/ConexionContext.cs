using Microsoft.EntityFrameworkCore;
using SistemaWebMic.Models.Entidades;
using SistemaWebMic.Models.EntityConfiguration;

namespace SistemaWebMic.Conexion
{
    public class ConexionContext : DbContext
    {
        public ConexionContext(DbContextOptions<ConexionContext> options) : base(options) { }
        public DbSet<Datos_Espirituales> DEspiritual { get; set; }
        public DbSet<Datos_Sociedad> DSociedad { get; set; }
        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Datos_EspiritualesConfiguration());
            modelBuilder.ApplyConfiguration(new Datos_SociedadConfiguration());
            modelBuilder.ApplyConfiguration(new PersonaConfiguration());
        }
    }
}