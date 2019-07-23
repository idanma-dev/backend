using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class IsPrivate_ToBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPrivate",
                table: "Product",
                nullable: false,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "IsPrivate",
                table: "Product",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
