using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class properties2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlignItems",
                table: "Container",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlexDirection",
                table: "Container",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlexWrap",
                table: "Container",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JustifyContent",
                table: "Container",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlignItems",
                table: "Container");

            migrationBuilder.DropColumn(
                name: "FlexDirection",
                table: "Container");

            migrationBuilder.DropColumn(
                name: "FlexWrap",
                table: "Container");

            migrationBuilder.DropColumn(
                name: "JustifyContent",
                table: "Container");
        }
    }
}
