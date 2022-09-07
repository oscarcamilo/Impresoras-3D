using Microsoft.EntityFrameworkCore.Migrations;

namespace Impresora3d.App.Persistencia.Migrations
{
    public partial class Ini8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impresoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaInventario = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisDeOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumenImpresion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Software = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VelocidadImpresion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresoras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impresoras");
        }
    }
}
