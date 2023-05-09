using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class filtrotype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filtro_Story_StoryId1",
                table: "Filtro");

            migrationBuilder.DropIndex(
                name: "IX_Filtro_StoryId1",
                table: "Filtro");

            migrationBuilder.DropColumn(
                name: "StoryId1",
                table: "Filtro");

            migrationBuilder.AlterColumn<long>(
                name: "StoryId",
                table: "Filtro",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Filtro_StoryId",
                table: "Filtro",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filtro_Story_StoryId",
                table: "Filtro",
                column: "StoryId",
                principalTable: "Story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filtro_Story_StoryId",
                table: "Filtro");

            migrationBuilder.DropIndex(
                name: "IX_Filtro_StoryId",
                table: "Filtro");

            migrationBuilder.AlterColumn<int>(
                name: "StoryId",
                table: "Filtro",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "StoryId1",
                table: "Filtro",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filtro_StoryId1",
                table: "Filtro",
                column: "StoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Filtro_Story_StoryId1",
                table: "Filtro",
                column: "StoryId1",
                principalTable: "Story",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
