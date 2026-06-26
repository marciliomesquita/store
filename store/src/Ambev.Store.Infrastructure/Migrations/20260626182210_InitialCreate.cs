using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.Store.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NumeroVenda = table.Column<Guid>(type: "uuid", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorTotalVenda = table.Column<decimal>(type: "numeric", nullable: false),
                    FilialRVenda = table.Column<Guid>(type: "uuid", nullable: false),
                    Produtos = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    Quantidades = table.Column<List<int>>(type: "integer[]", nullable: true),
                    PrecosUnitarios = table.Column<List<decimal>>(type: "numeric[]", nullable: true),
                    Descontos = table.Column<List<decimal>>(type: "numeric[]", nullable: true),
                    ValorTotalItens = table.Column<List<decimal>>(type: "numeric[]", nullable: true),
                    Cancelado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
