using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentCar.Server.Migrations
{
    public partial class ConnectionUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a77b329-1d10-4fb7-be20-6cbfea1b0865",
                column: "ConcurrencyStamp",
                value: "7a4ec5c8-b1bb-46dd-ab62-11ebfe4b35d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "847373b0-ff6f-11eb-9a03-0242ac130003",
                column: "ConcurrencyStamp",
                value: "582d3f8e-96dd-4ea2-aadc-346f7e52e500");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 566, DateTimeKind.Local).AddTicks(3920), new DateTime(2021, 8, 17, 13, 41, 5, 572, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 572, DateTimeKind.Local).AddTicks(8389), new DateTime(2021, 8, 17, 13, 41, 5, 572, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 574, DateTimeKind.Local).AddTicks(6533), new DateTime(2021, 8, 17, 13, 41, 5, 574, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 574, DateTimeKind.Local).AddTicks(7076), new DateTime(2021, 8, 17, 13, 41, 5, 574, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 575, DateTimeKind.Local).AddTicks(2928), new DateTime(2021, 8, 17, 13, 41, 5, 575, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 41, 5, 575, DateTimeKind.Local).AddTicks(4702), new DateTime(2021, 8, 17, 13, 41, 5, 575, DateTimeKind.Local).AddTicks(4781) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a77b329-1d10-4fb7-be20-6cbfea1b0865",
                column: "ConcurrencyStamp",
                value: "1644b0fe-d7d2-4275-84d8-6ddf1ca14856");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "847373b0-ff6f-11eb-9a03-0242ac130003",
                column: "ConcurrencyStamp",
                value: "6dbbd06e-14ec-4d38-a05e-6c9ab9abc5da");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(1901), new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(2403), new DateTime(2021, 8, 17, 13, 25, 25, 823, DateTimeKind.Local).AddTicks(2414) });
        }
    }
}
