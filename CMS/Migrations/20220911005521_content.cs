using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Content",
                table: "Div",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Content",
                table: "Container",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Container");
        }
    }
}
