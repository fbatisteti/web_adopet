using Microsoft.EntityFrameworkCore.Migrations;

namespace web_adopet.Server.Migrations
{
    public partial class Hotfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Racas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Racas_CategoriaId",
                table: "Racas",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Racas_Categorias_CategoriaId",
                table: "Racas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racas_Categorias_CategoriaId",
                table: "Racas");

            migrationBuilder.DropIndex(
                name: "IX_Racas_CategoriaId",
                table: "Racas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Racas");
        }
    }
}
