using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class removeproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Margem",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "Menu",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "Topo",
                table: "Pagina");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Margem",
                table: "Pagina",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Menu",
                table: "Pagina",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Topo",
                table: "Pagina",
                nullable: false,
                defaultValue: false);
        }
    }
}
