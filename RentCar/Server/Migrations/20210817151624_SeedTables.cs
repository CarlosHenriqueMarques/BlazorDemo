using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Server.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 17, 11, 16, 23, 338, DateTimeKind.Local).AddTicks(1663), new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(6324), "Black", "System" },
                    { 2, "System", new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(7743), new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(7757), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7092), new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7181), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7693), new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7705), "Hyundai", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2191), new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2214), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2732), new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2744), "Hyundai", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
