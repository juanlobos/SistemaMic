using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebMic.Models.Entidades;

namespace SistemaWebMic.Models.EntityConfiguration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Nombres).HasMaxLength(50);
            builder.Property(o => o.Apellidos).HasMaxLength(50);
            builder.Property(o => o.Fecha_Nacimiento).IsRequired().HasColumnType("date");
            builder.Property(o => o.Nacionalidad).IsRequired().HasMaxLength(25);
            builder.Property(o => o.Direccion).HasMaxLength(50);
            builder.Property(o => o.Comuna).HasMaxLength(25);
            builder.Property(o => o.TCelular).HasMaxLength(15);
            builder.Property(o => o.TCasa).HasMaxLength(15);
            builder.Property(o => o.Email).HasMaxLength(50);
            builder.Property(o => o.Facebook).HasMaxLength(50);
            builder.Property(o => o.Estado_Civil).HasMaxLength(25);
            builder.Property(o => o.Nombre_Pareja).HasMaxLength(50);

            builder.HasOne(a => a.Espiritual)
        .WithOne(b => b.Persona)
        .HasForeignKey<Datos_Espirituales>(b => b.PersonaId);

            builder.HasOne(a => a.Sociedad)
            .WithOne(b => b.Persona)
            .HasForeignKey<Datos_Sociedad>(b => b.PersonaId);
        }
    }
}