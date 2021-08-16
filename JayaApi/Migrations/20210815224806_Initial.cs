using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JayaApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    MoedaOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorOrigem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoedaDestino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDestino = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxaConversao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
