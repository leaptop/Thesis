using Microsoft.EntityFrameworkCore.Migrations;

namespace _012.Data.Migrations
{
    public partial class madeFieldCardNumberWithAttributeOfCardNumber2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "change",
                table: "CardT",
                newName: "changeBalance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "changeBalance",
                table: "CardT",
                newName: "change");
        }
    }
}
