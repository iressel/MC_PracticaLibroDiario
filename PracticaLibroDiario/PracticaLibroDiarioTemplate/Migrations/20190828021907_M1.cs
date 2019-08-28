using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaLibroDiarioTemplate.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibroMayor",
                columns: table => new
                {
                    AsientoLibroMayorId = table.Column<Guid>(nullable: false),
                    Detalle = table.Column<string>(nullable: true),
                    Debe = table.Column<decimal>(nullable: false),
                    Haber = table.Column<decimal>(nullable: false),
                    NombreCuenta = table.Column<string>(nullable: true),
                    Folio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroMayor", x => x.AsientoLibroMayorId);
                });

            migrationBuilder.CreateTable(
                name: "LibroDiario",
                columns: table => new
                {
                    AsientoLibroDiarioId = table.Column<Guid>(nullable: false),
                    Detalle = table.Column<string>(nullable: true),
                    Debe = table.Column<decimal>(nullable: false),
                    Haber = table.Column<decimal>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FolioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroDiario", x => x.AsientoLibroDiarioId);
                    table.ForeignKey(
                        name: "FK_LibroDiario_LibroMayor_FolioId",
                        column: x => x.FolioId,
                        principalTable: "LibroMayor",
                        principalColumn: "AsientoLibroMayorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibroDiario_FolioId",
                table: "LibroDiario",
                column: "FolioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroDiario");

            migrationBuilder.DropTable(
                name: "LibroMayor");
        }
    }
}
