using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioBlog.Web.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                schema: "bioblog",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                schema: "bioblog",
                newName: "usuarios",
                newSchema: "bioblog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                schema: "bioblog",
                table: "usuarios",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                schema: "bioblog",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                schema: "bioblog",
                newName: "Usuarios",
                newSchema: "bioblog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                schema: "bioblog",
                table: "Usuarios",
                column: "Id");
        }
    }
}
