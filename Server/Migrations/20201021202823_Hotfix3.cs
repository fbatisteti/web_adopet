using Microsoft.EntityFrameworkCore.Migrations;

namespace web_adopet.Server.Migrations
{
    public partial class Hotfix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nome" },
                values: new object[] { 1, "Cão" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Nome" },
                values: new object[] { 2, "Gato" });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "OngId", "Nome" },
                values: new object[] { 1, "ONG" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "RacaId", "CategoriaId", "Nome" },
                values: new object[] { 1, 1, "Vira-Lata" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "RacaId", "CategoriaId", "Nome" },
                values: new object[] { 2, 2, "Vira-Lata" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ongs",
                keyColumn: "OngId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Racas",
                keyColumn: "RacaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Racas",
                keyColumn: "RacaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2);
        }
    }
}
