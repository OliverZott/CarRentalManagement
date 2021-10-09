using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class RoleSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "86bafafe-3271-467f-b6ea-32967995ac65", "5d10cc4b-9572-428e-8add-ae3d841fa379", "User", "USER" },
                    { "932ab41a-fdf0-4d0c-be4e-47414fceaf99", "a68b2603-50f7-4514-aca1-5ee24caf78ea", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 986, DateTimeKind.Local).AddTicks(8748), new DateTime(2021, 10, 9, 16, 3, 38, 989, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 989, DateTimeKind.Local).AddTicks(2276), new DateTime(2021, 10, 9, 16, 3, 38, 989, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 989, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 10, 9, 16, 3, 38, 989, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(4992), new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(5022), new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8829), new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8849), new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8855), new DateTime(2021, 10, 9, 16, 3, 38, 990, DateTimeKind.Local).AddTicks(8857) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 937, DateTimeKind.Local).AddTicks(1802), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5131), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5149), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8433), new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8458), new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1724), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1744), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1750), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1752) });
        }
    }
}
