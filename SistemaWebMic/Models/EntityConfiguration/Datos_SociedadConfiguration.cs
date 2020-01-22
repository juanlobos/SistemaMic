using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebMic.Models.Entidades;

namespace SistemaWebMic.Models.EntityConfiguration
{
    public class Datos_SociedadConfiguration : IEntityTypeConfiguration<Datos_Sociedad>
    {
        public void Configure(EntityTypeBuilder<Datos_Sociedad> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.NivelEducacion).HasMaxLength(50);
            builder.Property(o => o.Profesion).HasMaxLength(50);
            builder.Property(o => o.LugarTrabajo).HasMaxLength(50);
        }
    }
}