using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracaoSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produtos",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categorias",
                newSchema: "public");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Produtos",
                schema: "public",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "Categorias",
                schema: "public",
                newName: "Categorias");
        }
    }
}
