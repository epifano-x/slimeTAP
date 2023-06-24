using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlimeTAP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioNome = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Moeda = table.Column<float>(type: "REAL", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: true),
                    Diamante = table.Column<int>(type: "INTEGER", nullable: true),
                    Gema = table.Column<int>(type: "INTEGER", nullable: true),
                    Multiplicador = table.Column<float>(type: "REAL", nullable: true),
                    Upgrade1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Upgrade2 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
