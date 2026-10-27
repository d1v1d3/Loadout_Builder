using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoadoutBuilder.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedLoadouts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camos",
                columns: new[] { "Id", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Default weapon appearance", false, "Default" },
                    { 2, "Forest camouflage", false, "Forest" },
                    { 3, "Desert camouflage", false, "Desert" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Assault Rifle" },
                    { 2, "SMG" },
                    { 3, "Sniper Rifle" }
                });

            migrationBuilder.InsertData(
                table: "Sight",
                columns: new[] { "Id", "IsDeleted", "Range", "Type" },
                values: new object[,]
                {
                    { 1, false, 0, "Red Dot" },
                    { 2, false, 1, "Holographic" },
                    { 3, false, 2, "Sniper Scope" }
                });

            migrationBuilder.InsertData(
                table: "SightCategory",
                columns: new[] { "CotegoryId", "SightId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CotegoryId", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Assault rifle", false, "M4" },
                    { 2, 2, "Submachine gun", false, "MP5" },
                    { 3, 3, "Sniper rifle", false, "AWP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SightCategory",
                keyColumns: new[] { "CotegoryId", "SightId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SightCategory",
                keyColumns: new[] { "CotegoryId", "SightId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SightCategory",
                keyColumns: new[] { "CotegoryId", "SightId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SightCategory",
                keyColumns: new[] { "CotegoryId", "SightId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SightCategory",
                keyColumns: new[] { "CotegoryId", "SightId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sight",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sight",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sight",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
