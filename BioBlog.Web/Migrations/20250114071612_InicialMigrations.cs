using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioBlog.Web.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bioblog");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuarios",
                newSchema: "bioblog");

            migrationBuilder.RenameTable(
                name: "Artigos",
                newName: "Artigos",
                newSchema: "bioblog");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Usuarios",
                schema: "bioblog",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Artigos",
                schema: "bioblog",
                newName: "Artigos");
        }
    }
}
