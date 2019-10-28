using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 3, "Los Angelos" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 4, "Paris" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 5, "Venice" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 6, "Hong Kong" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 7, "London" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 8, "Delhi" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 9, "Nairobi" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 10, "Bali" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 11, "Brasilia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11);
        }
    }
}
