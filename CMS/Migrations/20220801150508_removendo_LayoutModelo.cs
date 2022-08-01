using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class removendo_LayoutModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LayoutModelo",
                table: "Pagina");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LayoutModelo",
                table: "Pagina",
                nullable: false,
                defaultValue: false);
        }
    }
}
