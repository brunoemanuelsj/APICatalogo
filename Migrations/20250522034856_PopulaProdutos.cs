﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql(@"
                INSERT INTO produtos (""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")
                VALUES ('Coca-Cola Diet', 'Refrigerante de Cola 350 ml', 5.45, 'cocacola.jpg', 50, NOW(), 1);
            ");

            mb.Sql(@"
                INSERT INTO produtos (""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")
                VALUES ('Lanche de Atum', 'Lanche de Atum com maionese', 8.50, 'atum.jpg', 10, NOW(), 2);
            ");

            mb.Sql(@"
                INSERT INTO produtos (""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")
                VALUES ('Pudim 100 g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg', 20, NOW(), 3);
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql(@"DELETE FROM ""Produtos"";");
        }
    }
}