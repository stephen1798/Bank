using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class AktualizacjaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "CurrencyDbModels",
                newName: "rateDateTime");

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "CurrencyDbModels",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "CurrencyDbModels");

            migrationBuilder.RenameColumn(
                name: "rateDateTime",
                table: "CurrencyDbModels",
                newName: "date");
        }
    }
}
