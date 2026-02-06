using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleCars.API.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaVeiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "text", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Ano = table.Column<int>(type: "integer", nullable: false),
                    Quilometragem = table.Column<int>(type: "integer", nullable: false),
                    Cor = table.Column<int>(type: "integer", nullable: false),
                    Carroceria = table.Column<int>(type: "integer", nullable: false),
                    Cambio = table.Column<int>(type: "integer", nullable: false),
                    Combustivel = table.Column<int>(type: "integer", nullable: false),
                    PrecoCompra = table.Column<decimal>(type: "numeric", nullable: false),
                    PrecoAnuncio = table.Column<decimal>(type: "numeric", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "numeric", nullable: true),
                    Atualizacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Placa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
