using Microsoft.EntityFrameworkCore.Migrations;

namespace Pallavolo.DA.Migrations
{
    public partial class FixGiocatore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Giocatori",
                newName: "Numero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Giocatori",
                newName: "numero");
        }
    }
}
