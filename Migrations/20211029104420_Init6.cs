using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AimsCarRentals.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 44, 18, 775, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 44, 18, 775, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 44, 18, 775, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 44, 18, 775, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 23, 44, 18, 769, DateTimeKind.Local).AddTicks(1662));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 27, 42, 762, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 27, 42, 762, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 27, 42, 762, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 23, 27, 42, 762, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 23, 27, 42, 758, DateTimeKind.Local).AddTicks(87));
        }
    }
}
