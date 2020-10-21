using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_adopet.Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Ongs",
                columns: table => new
                {
                    OngId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ongs", x => x.OngId);
                });

            migrationBuilder.CreateTable(
                name: "Racas",
                columns: table => new
                {
                    RacaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racas", x => x.RacaId);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Chipado = table.Column<bool>(nullable: false),
                    Personalidade = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: false),
                    RacaId = table.Column<int>(nullable: false),
                    OngId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animais_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animais_Ongs_OngId",
                        column: x => x.OngId,
                        principalTable: "Ongs",
                        principalColumn: "OngId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animais_Racas_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Racas",
                        principalColumn: "RacaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoId);
                    table.ForeignKey(
                        name: "FK_Fotos_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    HistoricoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalId = table.Column<int>(nullable: false),
                    VacinasId = table.Column<int>(nullable: false),
                    Anotacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.HistoricoId);
                    table.ForeignKey(
                        name: "FK_Historicos_Animais_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animais",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacinas",
                columns: table => new
                {
                    VacinaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HistoricoId = table.Column<int>(nullable: false),
                    NomeDaVacina = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacinas", x => x.VacinaId);
                    table.ForeignKey(
                        name: "FK_Vacinas_Historicos_HistoricoId",
                        column: x => x.HistoricoId,
                        principalTable: "Historicos",
                        principalColumn: "HistoricoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_CategoriaId",
                table: "Animais",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_OngId",
                table: "Animais",
                column: "OngId");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_RacaId",
                table: "Animais",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_AnimalId",
                table: "Fotos",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_AnimalId",
                table: "Historicos",
                column: "AnimalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacinas_HistoricoId",
                table: "Vacinas",
                column: "HistoricoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Vacinas");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Ongs");

            migrationBuilder.DropTable(
                name: "Racas");
        }
    }
}
