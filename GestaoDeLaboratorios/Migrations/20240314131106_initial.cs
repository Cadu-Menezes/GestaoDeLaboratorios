using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    marca = table.Column<string>(type: "TEXT", nullable: false),
                    processador = table.Column<string>(type: "TEXT", nullable: false),
                    placaMae = table.Column<string>(type: "TEXT", nullable: false),
                    memoria = table.Column<int>(type: "INTEGER", nullable: false),
                    hd = table.Column<string>(type: "TEXT", nullable: false),
                    numeroPratrimonio = table.Column<string>(type: "TEXT", nullable: false),
                    dataCompra = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
