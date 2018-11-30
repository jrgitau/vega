using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class AddedCarModelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Prado" },
                    { 2, "Auris" },
                    { 3, "Camry" },
                    { 4, "X6" },
                    { 5, "CRV" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
