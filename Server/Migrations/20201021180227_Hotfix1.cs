using Microsoft.EntityFrameworkCore.Migrations;

namespace web_adopet.Server.Migrations
{
    public partial class Hotfix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeDaVacina",
                table: "Vacinas");

            migrationBuilder.AddColumn<bool>(
                name: "Giardia",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Leishmaniose",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Raiva",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Traqueobronquite",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V10",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V12",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V3",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V4",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V5",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "V8",
                table: "Vacinas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Giardia",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "Leishmaniose",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "Raiva",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "Traqueobronquite",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V10",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V12",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V3",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V4",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V5",
                table: "Vacinas");

            migrationBuilder.DropColumn(
                name: "V8",
                table: "Vacinas");

            migrationBuilder.AddColumn<bool>(
                name: "NomeDaVacina",
                table: "Vacinas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
