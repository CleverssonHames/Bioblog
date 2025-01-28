using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioBlog.Web.Migrations
{
    /// <inheritdoc />
    public partial class ConfgTableArtigos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Artigos",
                schema: "bioblog",
                table: "Artigos");

            migrationBuilder.RenameTable(
                name: "Artigos",
                schema: "bioblog",
                newName: "artigos",
                newSchema: "bioblog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artigos",
                schema: "bioblog",
                table: "artigos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_artigos",
                schema: "bioblog",
                table: "artigos");

            migrationBuilder.RenameTable(
                name: "artigos",
                schema: "bioblog",
                newName: "Artigos",
                newSchema: "bioblog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artigos",
                schema: "bioblog",
                table: "Artigos",
                column: "Id");
        }
    }
}
