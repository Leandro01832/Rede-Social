using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class widthelemento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Elemento",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "Elemento");
        }
    }
}
