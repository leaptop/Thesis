using Microsoft.EntityFrameworkCore.Migrations;

namespace _012.Data.Migrations
{
    public partial class Accountsaddition3addedabiggerrangeforBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {//Up is what's gonna appear, Down is what's gonna disappear
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "AccountsT",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "AccountsT",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
