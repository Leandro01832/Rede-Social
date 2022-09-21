using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlignItems",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlexDirection",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlignItems",
                table: "Div",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlexDirection",
                table: "Div",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlexWrap",
                table: "Div",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JustifyContent",
                table: "Div",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Div",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Container",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlignItems",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "FlexDirection",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "AlignItems",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "FlexDirection",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "FlexWrap",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "JustifyContent",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Div");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Container");
        }
    }
}
