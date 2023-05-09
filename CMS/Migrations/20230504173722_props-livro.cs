using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class propslivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capitulo",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Compartilhando",
                table: "Livro",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capitulo",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Compartilhando",
                table: "Livro");
        }
    }
}
