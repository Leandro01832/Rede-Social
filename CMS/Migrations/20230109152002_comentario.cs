using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class comentario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Comentario",
                table: "Story",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "Story");
        }
    }
}
