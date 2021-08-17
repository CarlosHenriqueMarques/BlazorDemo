using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Server.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "847373b0-ff6f-11eb-9a03-0242ac130003", "6dbbd06e-14ec-4d38-a05e-6c9ab9abc5da", "User", "USER" },
                    { "1a77b329-1d10-4fb7-be20-6cbfea1b0865", "1644b0fe-d7d2-4275-84d8-6ddf1ca14856", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 813, DateTimeKind.Local).AddTicks(8812), new DateTime(2021, 8, 17, 13, 25, 25, 820, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 820, DateTimeKind.Local).AddTicks(9180), new DateTime(2021, 8, 17, 13, 25, 25, 820, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 822, DateTimeKind.Local).AddTicks(7311), new DateTime(2021, 8, 17, 13, 25, 25, 822, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 822, DateTimeKind.Local).AddTicks(7823), new DateTime(2021, 8, 17, 13, 25, 25, 822, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(1901), new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(1922), "Prius" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(2403), new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(2414), "Elantra" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a77b329-1d10-4fb7-be20-6cbfea1b0865");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "847373b0-ff6f-11eb-9a03-0242ac130003");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 338, DateTimeKind.Local).AddTicks(1663), new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(7743), new DateTime(2021, 8, 17, 11, 16, 23, 344, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7092), new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7693), new DateTime(2021, 8, 17, 11, 16, 23, 346, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2191), new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2214), "Toyota" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2732), new DateTime(2021, 8, 17, 11, 16, 23, 347, DateTimeKind.Local).AddTicks(2744), "Hyundai" });
        }
    }
}
