using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class pular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Pular",
                table: "Pagina",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pular",
                table: "Pagina");
        }
    }
}
