using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(maxLength: 50, nullable: true),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "date", nullable: false),
                    Nacionalidad = table.Column<string>(maxLength: 25, nullable: false),
                    Direccion = table.Column<string>(maxLength: 50, nullable: true),
                    Comuna = table.Column<string>(maxLength: 25, nullable: true),
                    TCelular = table.Column<string>(maxLength: 15, nullable: true),
                    TCasa = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Facebook = table.Column<string>(maxLength: 50, nullable: true),
                    Estado_Civil = table.Column<string>(maxLength: 25, nullable: true),
                    Nombre_Pareja = table.Column<string>(maxLength: 50, nullable: true),
                    Hijos = table.Column<bool>(nullable: true),
                    Cantidad_Hijos = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DEspiritual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Llegada_Iglesia = table.Column<string>(maxLength: 100, nullable: true),
                    Invitacion_Iglesia = table.Column<string>(maxLength: 50, nullable: true),
                    Cuando_Congrega = table.Column<string>(maxLength: 100, nullable: true),
                    VisitaPrimera = table.Column<bool>(nullable: false),
                    Acepto_Jesus = table.Column<bool>(nullable: false),
                    Anio = table.Column<int>(nullable: true),
                    Bautizado = table.Column<bool>(nullable: false),
                    LugarBautismo = table.Column<string>(maxLength: 100, nullable: true),
                    FechaBautismo = table.Column<DateTime>(nullable: true),
                    Razones_Mic = table.Column<string>(maxLength: 250, nullable: true),
                    RecibirConsejeria = table.Column<bool>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEspiritual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEspiritual_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DSociedad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NivelEducacion = table.Column<string>(maxLength: 50, nullable: true),
                    Profesion = table.Column<string>(maxLength: 50, nullable: true),
                    LugarTrabajo = table.Column<string>(maxLength: 50, nullable: true),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DSociedad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DSociedad_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEspiritual_PersonaId",
                table: "DEspiritual",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DSociedad_PersonaId",
                table: "DSociedad",
                column: "PersonaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEspiritual");

            migrationBuilder.DropTable(
                name: "DSociedad");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
