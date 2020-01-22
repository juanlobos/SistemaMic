﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWebMic.Conexion;

namespace SistemaWebMic.Migrations
{
    [DbContext(typeof(ConexionContext))]
    partial class ConexionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaWebMic.Models.Entidades.Datos_Espirituales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acepto_Jesus");

                    b.Property<int?>("Anio");

                    b.Property<bool>("Bautizado");

                    b.Property<string>("Cuando_Congrega")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("FechaBautismo");

                    b.Property<string>("Invitacion_Iglesia")
                        .HasMaxLength(50);

                    b.Property<string>("Llegada_Iglesia")
                        .HasMaxLength(100);

                    b.Property<string>("LugarBautismo")
                        .HasMaxLength(100);

                    b.Property<int>("PersonaId");

                    b.Property<string>("Razones_Mic")
                        .HasMaxLength(250);

                    b.Property<bool>("RecibirConsejeria");

                    b.Property<bool>("VisitaPrimera");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("DEspiritual");
                });

            modelBuilder.Entity("SistemaWebMic.Models.Entidades.Datos_Sociedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LugarTrabajo")
                        .HasMaxLength(50);

                    b.Property<string>("NivelEducacion")
                        .HasMaxLength(50);

                    b.Property<int>("PersonaId");

                    b.Property<string>("Profesion")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("DSociedad");
                });

            modelBuilder.Entity("SistemaWebMic.Models.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasMaxLength(50);

                    b.Property<int?>("Cantidad_Hijos");

                    b.Property<string>("Comuna")
                        .HasMaxLength(25);

                    b.Property<string>("Direccion")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Estado_Civil")
                        .HasMaxLength(25);

                    b.Property<string>("Facebook")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("date");

                    b.Property<bool?>("Hijos");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Nombre_Pareja")
                        .HasMaxLength(50);

                    b.Property<string>("Nombres")
                        .HasMaxLength(50);

                    b.Property<string>("TCasa")
                        .HasMaxLength(15);

                    b.Property<string>("TCelular")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("SistemaWebMic.Models.Entidades.Datos_Espirituales", b =>
                {
                    b.HasOne("SistemaWebMic.Models.Entidades.Persona", "Persona")
                        .WithOne("Espiritual")
                        .HasForeignKey("SistemaWebMic.Models.Entidades.Datos_Espirituales", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaWebMic.Models.Entidades.Datos_Sociedad", b =>
                {
                    b.HasOne("SistemaWebMic.Models.Entidades.Persona", "Persona")
                        .WithOne("Sociedad")
                        .HasForeignKey("SistemaWebMic.Models.Entidades.Datos_Sociedad", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
