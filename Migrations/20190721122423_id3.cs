using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class id3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product",
                newName: "pID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pID",
                table: "Product",
                newName: "ID");
        }
    }
}
