using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class agrupamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "GrupoId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubGrupoId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubStoryId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubSubGrupoId",
                table: "Pagina",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubStory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubStory_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubStoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupo_SubStory_SubStoryId",
                        column: x => x.SubStoryId,
                        principalTable: "SubStory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubGrupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGrupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubGrupo_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSubGrupo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubGrupoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubGrupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubSubGrupo_SubGrupo_SubGrupoId",
                        column: x => x.SubGrupoId,
                        principalTable: "SubGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_GrupoId",
                table: "Pagina",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubGrupoId",
                table: "Pagina",
                column: "SubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubStoryId",
                table: "Pagina",
                column: "SubStoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagina_SubSubGrupoId",
                table: "Pagina",
                column: "SubSubGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_SubStoryId",
                table: "Grupo",
                column: "SubStoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGrupo_GrupoId",
                table: "SubGrupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_SubStory_StoryId",
                table: "SubStory",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSubGrupo_SubGrupoId",
                table: "SubSubGrupo",
                column: "SubGrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_Grupo_GrupoId",
                table: "Pagina",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_SubGrupo_SubGrupoId",
                table: "Pagina",
                column: "SubGrupoId",
                principalTable: "SubGrupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_SubStory_SubStoryId",
                table: "Pagina",
                column: "SubStoryId",
                principalTable: "SubStory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagina_SubSubGrupo_SubSubGrupoId",
                table: "Pagina",
                column: "SubSubGrupoId",
                principalTable: "SubSubGrupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_Grupo_GrupoId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_SubGrupo_SubGrupoId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_SubStory_SubStoryId",
                table: "Pagina");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagina_SubSubGrupo_SubSubGrupoId",
                table: "Pagina");

            migrationBuilder.DropTable(
                name: "SubSubGrupo");

            migrationBuilder.DropTable(
                name: "SubGrupo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "SubStory");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_GrupoId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_SubGrupoId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_SubStoryId",
                table: "Pagina");

            migrationBuilder.DropIndex(
                name: "IX_Pagina_SubSubGrupoId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "SubGrupoId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "SubStoryId",
                table: "Pagina");

            migrationBuilder.DropColumn(
                name: "SubSubGrupoId",
                table: "Pagina");
        }
    }
}
