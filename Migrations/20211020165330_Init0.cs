using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AimsCarRentals.Migrations
{
    public partial class Init0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Users",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 53, 29, 340, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 53, 29, 340, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 53, 29, 340, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 53, 29, 340, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DateOfBirth", "FirstName", "Gender", "LastName", "MiddleName", "PhoneNo" },
                values: new object[] { "Asero,Abk", new DateTime(2021, 10, 20, 5, 53, 29, 334, DateTimeKind.Local).AddTicks(7824), "Jafar", "Male", "Lawal", "Okikiola", "09071681776" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 19, 10, 205, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 19, 10, 208, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 19, 10, 208, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 20, 5, 19, 10, 208, DateTimeKind.Local).AddTicks(7184));
        }
    }
}
