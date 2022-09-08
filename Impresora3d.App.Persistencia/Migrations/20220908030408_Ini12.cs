using Microsoft.EntityFrameworkCore.Migrations;

namespace Impresora3d.App.Persistencia.Migrations
{
    public partial class Ini12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Impresoras",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Impresoras",
                newName: "Marca");

            migrationBuilder.AddColumn<string>(
                name: "Auxiliar_Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Auxiliar_NivelEstudio",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auxiliar_Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Auxiliar_NivelEstudio",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Impresoras",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Impresoras",
                newName: "marca");
        }
    }
}
