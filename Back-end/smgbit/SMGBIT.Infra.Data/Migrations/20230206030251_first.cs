using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SMGBIT.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fretes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTabela = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    TipoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fretes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataViagem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroViagem = table.Column<int>(type: "int", nullable: false),
                    Motorista = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TipoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaixasCarregadas = table.Column<int>(type: "int", nullable: false),
                    Entregas = table.Column<int>(type: "int", nullable: false),
                    KmRodado = table.Column<int>(type: "int", nullable: false),
                    TipoViagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TabelaViagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorViagem = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Fretes",
                columns: new[] { "Id", "Cliente", "Destino", "NomeTabela", "TipoVeiculo", "Valor" },
                values: new object[,]
                {
                    { 1, "CDD Ribeirão Preto", null, "table_1", "VUC", 900.0 },
                    { 2, "CDD Ribeirão Preto", null, "table_2", "CARRETA", 812.0 },
                    { 3, "CDD Ribeirão Preto", null, "table_3", "VAN", 687.0 },
                    { 4, "CDD Ribeirão Preto", null, "table_4", "TRUCK", 702.0 },
                    { 5, "CDD São Paulo", "Regiao 2", "table_5", "TRUCK", 702.0 },
                    { 6, "CDD São Paulo", "Regiao 10", "table_6", "TRUCK", 698.0 },
                    { 7, "CDD São Paulo", "Regiao 7", "table_7", "TRUCK", 900.0 },
                    { 8, "CDD São Paulo", "Regiao 3", "table_8", "TRUCK", 777.0 },
                    { 9, "CDD São Paulo", "Regiao 3", "table_9", "VUC", 532.0 },
                    { 10, "CDD São Paulo", "Regiao 2", "table_10", "VUC", 502.0 },
                    { 11, "CDD São Paulo", "Regiao 10", "table_11", "VUC", 478.0 },
                    { 12, "CDD São Paulo", "Regiao 7", "table_12", "VUC", 690.0 },
                    { 13, "CDD São Paulo", "Regiao 7", "table_13", "VAN", 300.0 },
                    { 14, "CDD São Paulo", "Regiao 2", "table_14", "VAN", 412.0 },
                    { 15, "CDD São Paulo", "Regiao 3", "table_15", "VAN", 400.0 },
                    { 16, "CDD São Paulo", "Regiao 10", "table_16", "VAN", 541.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fretes");

            migrationBuilder.DropTable(
                name: "Viagens");
        }
    }
}
