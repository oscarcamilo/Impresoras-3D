using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Impresora3d.App.Persistencia.Migrations
{
    public partial class Ini3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorRevision = table.Column<int>(type: "int", nullable: false),
                    FechaHoraRevision = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revisiones");
        }
    }
}
