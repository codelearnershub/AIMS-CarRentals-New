using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AimsCarRentals.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 24, 0, 470, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 24, 0, 470, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 24, 0, 470, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 24, 0, 470, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 23, 24, 0, 463, DateTimeKind.Local).AddTicks(8397));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 21, 7, 195, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 21, 7, 195, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 21, 7, 195, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 21, 7, 196, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 23, 21, 7, 191, DateTimeKind.Local).AddTicks(6687));
        }
    }
}
