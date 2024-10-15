using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PedidoDetalhes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarinhoCompraItens_Lanches_LancheId",
                table: "CarinhoCompraItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarinhoCompraItens",
                table: "CarinhoCompraItens");

            migrationBuilder.RenameTable(
                name: "CarinhoCompraItens",
                newName: "CarrinhoCompraItens");

            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraID",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraId");

            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraItemID",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CarinhoCompraItens_LancheId",
                table: "CarrinhoCompraItens",
                newName: "IX_CarrinhoCompraItens_LancheId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Categorias",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaNome",
                table: "Categorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens",
                column: "CarrinhoCompraItemId");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PedidoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalItensPedido = table.Column<int>(type: "int", nullable: false),
                    PedidoEnviado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedidoEntregueEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "PedidoDetalhes",
                columns: table => new
                {
                    PedidoDetalheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    LancheId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoDetalhes", x => x.PedidoDetalheId);
                    table.ForeignKey(
                        name: "FK_PedidoDetalhes_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalhes_LancheId",
                table: "PedidoDetalhes",
                column: "LancheId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDetalhes_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                table: "CarrinhoCompraItens");

            migrationBuilder.DropTable(
                name: "PedidoDetalhes");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoCompraItens",
                table: "CarrinhoCompraItens");

            migrationBuilder.RenameTable(
                name: "CarrinhoCompraItens",
                newName: "CarinhoCompraItens");

            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraId",
                table: "CarinhoCompraItens",
                newName: "CarrinhoCompraID");

            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraItemId",
                table: "CarinhoCompraItens",
                newName: "CarrinhoCompraItemID");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarinhoCompraItens",
                newName: "IX_CarinhoCompraItens_LancheId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaNome",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarinhoCompraItens",
                table: "CarinhoCompraItens",
                column: "CarrinhoCompraItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarinhoCompraItens_Lanches_LancheId",
                table: "CarinhoCompraItens",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId");
        }
    }
}
