using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Donatore.DA.Migrations
{
    public partial class Giocatore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sangue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Added = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    fattorePositivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sangue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donatori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Added = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Indirizzo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    SangueId = table.Column<int>(nullable: true),
                    UltimaDonazione = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donatori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donatori_Sangue_SangueId",
                        column: x => x.SangueId,
                        principalTable: "Sangue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donatori_SangueId",
                table: "Donatori",
                column: "SangueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donatori");

            migrationBuilder.DropTable(
                name: "Sangue");
        }
    }
}
