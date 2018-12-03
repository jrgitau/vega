using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Makes_CarModels_CarModelId",
                table: "Makes");

            migrationBuilder.DropIndex(
                name: "IX_Makes_CarModelId",
                table: "Makes");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "Makes");

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "CarModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_MakeId",
                table: "CarModels",
                column: "MakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Makes_MakeId",
                table: "CarModels",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Makes_MakeId",
                table: "CarModels");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_MakeId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "CarModels");

            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "Makes",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "4 wheel drive" },
                    { 2, "ABS" },
                    { 3, "Central locking" },
                    { 4, "Reverse Camera" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CarModelId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Toyota" },
                    { 4, 2, "Toyota" },
                    { 2, 4, "BMW" },
                    { 3, 5, "Honda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Makes_CarModelId",
                table: "Makes",
                column: "CarModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Makes_CarModels_CarModelId",
                table: "Makes",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
