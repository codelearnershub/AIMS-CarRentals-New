using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AimsCarRentals.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Address", "DateOfBirth", "Email", "FirstName", "HashSalt", "LastName", "MiddleName", "PasswordHash" },
                values: new object[] { "asd", new DateTime(2021, 10, 28, 23, 21, 7, 191, DateTimeKind.Local).AddTicks(6687), "jafar@gmail.com", "jafar", "ftuIrIDS+TJqDpa0wGVv1w==", "lawal", "okiki", "Pq0zPzvnkKkIoa5prU80VcV6+i9BF1RhDTnDyuF7FMs=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Address", "DateOfBirth", "Email", "FirstName", "HashSalt", "LastName", "MiddleName", "PasswordHash" },
                values: new object[] { "Asero,Abk", new DateTime(2021, 10, 20, 5, 53, 29, 334, DateTimeKind.Local).AddTicks(7824), "okikiolalawal@gmail.com", "Jafar", "d+RzYMAQvvCJ+aNedX1uDg==", "Lawal", "Okikiola", "SehzKv9PAiawVd3TeV1QkkgBlCz67YoY7WMm4FB836c=" });
        }
    }
}
