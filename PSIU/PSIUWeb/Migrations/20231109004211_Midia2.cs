using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class Midia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MidiaID",
                table: "Midias",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Midias",
                newName: "MidiaID");
        }
    }
}
