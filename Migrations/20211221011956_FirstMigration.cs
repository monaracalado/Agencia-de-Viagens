using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_MVC.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CPF = table.Column<string>(type: "char(11)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "char(40)", nullable: false),
                    Sexo = table.Column<string>(type: "text", nullable: false),
                    Telefone1 = table.Column<string>(type: "char(15)", nullable: false),
                    Telefone2 = table.Column<string>(type: "char(15)", nullable: false),
                    Origem = table.Column<string>(type: "text", nullable: false),
                    Destino = table.Column<string>(type: "text", nullable: false),
                    DataIda = table.Column<DateTime>(type: "date", nullable: false),
                    DataVolta = table.Column<DateTime>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
