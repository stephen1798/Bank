using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class ChangeNameClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyDbModels",
                table: "CurrencyDbModels");

            migrationBuilder.RenameTable(
                name: "CurrencyDbModels",
                newName: "CurrencyDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyDb",
                table: "CurrencyDb",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyDb",
                table: "CurrencyDb");

            migrationBuilder.RenameTable(
                name: "CurrencyDb",
                newName: "CurrencyDbModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyDbModels",
                table: "CurrencyDbModels",
                column: "Id");
        }
    }
}
