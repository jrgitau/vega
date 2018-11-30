using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class AddedMakesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CarModelId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Toyota" },
                    { 2, 4, "BMW" },
                    { 3, 5, "Honda" },
                    { 4, 2, "Toyota" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
