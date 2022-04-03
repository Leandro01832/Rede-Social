using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class Inicio4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_AspNetUsers_UserModelId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_UserModelId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Pagina");

            migrationBuilder.AlterColumn<int>(
                name: "PaginaPadraoLink",
                table: "Story",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Pagina",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Seguidor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    UserModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguidor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguidor_AspNetUsers_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seguindo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    UserModelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguindo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seguindo_AspNetUsers_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seguidor_UserModelId",
                table: "Seguidor",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguindo_UserModelId",
                table: "Seguindo",
                column: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seguidor");

            migrationBuilder.DropTable(
                name: "Seguindo");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Pagina");

            migrationBuilder.AlterColumn<int>(
                name: "PaginaPadraoLink",
                table: "Story",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "UserModelId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_UserModelId",
                table: "Pagina",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_AspNetUsers_UserModelId",
                table: "Pagina",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
