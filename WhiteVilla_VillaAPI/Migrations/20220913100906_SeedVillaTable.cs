using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteVilla_VillaAPI.Migrations
{
    public partial class SeedVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImgUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "The best", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The First villa in our project", "", "First", 1, 10.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "The best", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Second villa in our project", "", "Second", 2, 10.0, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "The best", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Third villa in our project", "", "Third", 3, 10.0, 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "The best", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fourth villa in our project", "", "Fourth", 4, 10.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "The best", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fifth villa in our project", "", "Fifth", 5, 10.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
