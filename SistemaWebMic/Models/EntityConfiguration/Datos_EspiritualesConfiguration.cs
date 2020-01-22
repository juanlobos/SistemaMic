using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebMic.Models.Entidades;

namespace SistemaWebMic.Models.EntityConfiguration
{
    public class Datos_EspiritualesConfiguration : IEntityTypeConfiguration<Datos_Espirituales>
    {
        public void Configure(EntityTypeBuilder<Datos_Espirituales> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Invitacion_Iglesia).HasMaxLength(50);
            builder.Property(o => o.Cuando_Congrega).HasMaxLength(100);
            builder.Property(o => o.Llegada_Iglesia).HasMaxLength(100);
            builder.Property(o => o.LugarBautismo).HasMaxLength(100);
            builder.Property(o => o.Razones_Mic).HasMaxLength(250);

        }
    }
}