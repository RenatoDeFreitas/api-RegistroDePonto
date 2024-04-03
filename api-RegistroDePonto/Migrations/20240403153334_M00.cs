using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_RegistroDePonto.Migrations
{
    public partial class M00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntradaManha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaidaManha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntradaTarde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaidaTarde = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro");
        }
    }
}
