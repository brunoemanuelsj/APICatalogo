using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class AjusteNomesTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                schema: "public",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                schema: "public",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                schema: "public",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Produtos",
                schema: "public",
                newName: "produtos",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Categorias",
                schema: "public",
                newName: "categorias",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                schema: "public",
                table: "produtos",
                newName: "IX_produtos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos",
                schema: "public",
                table: "produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorias",
                schema: "public",
                table: "categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                schema: "public",
                table: "produtos",
                column: "CategoriaId",
                principalSchema: "public",
                principalTable: "categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                schema: "public",
                table: "produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos",
                schema: "public",
                table: "produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorias",
                schema: "public",
                table: "categorias");

            migrationBuilder.RenameTable(
                name: "produtos",
                schema: "public",
                newName: "Produtos",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "categorias",
                schema: "public",
                newName: "Categorias",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_CategoriaId",
                schema: "public",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                schema: "public",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                schema: "public",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                schema: "public",
                table: "Produtos",
                column: "CategoriaId",
                principalSchema: "public",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
