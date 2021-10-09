using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UserAndUserRolesSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65",
                column: "ConcurrencyStamp",
                value: "7cbac734-37cf-4006-b56c-6e7ad0cf7b51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                column: "ConcurrencyStamp",
                value: "824cb918-31a7-4976-8f51-57ed138d29b1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "004938fa-d152-4d77-80fa-9ebd905e6175", 0, "f82a4dbd-dc6d-42b8-bad4-01c274622cf0", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKt4vejQoae2ufAa0wuF+HFns85Jt+wCOvxlKJHDlzbCe5HhG9fb7byAuiDE594kfA==", null, false, "ee68e515-dc44-4ce3-a77b-932fe5bbbd42", false, "admin@localhost.com" },
                    { "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e", 0, "3b0ba62c-a798-450e-946e-163fb0131ed1", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENv3G26hE+I30s897RwK/uEaxvcmUK4e0y8+P95AYFm6XFgT2ygXr1oz99nYAaqb+Q==", null, false, "f2830e77-b671-43d6-9fd0-a7a8010a72e5", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 522, DateTimeKind.Local).AddTicks(6515), new DateTime(2021, 10, 9, 16, 47, 22, 525, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 526, DateTimeKind.Local).AddTicks(1494), new DateTime(2021, 10, 9, 16, 47, 22, 526, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 526, DateTimeKind.Local).AddTicks(1534), new DateTime(2021, 10, 9, 16, 47, 22, 526, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 527, DateTimeKind.Local).AddTicks(9013), new DateTime(2021, 10, 9, 16, 47, 22, 527, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 527, DateTimeKind.Local).AddTicks(9069), new DateTime(2021, 10, 9, 16, 47, 22, 527, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3047), new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3088), new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3094), new DateTime(2021, 10, 9, 16, 47, 22, 528, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "932ab41a-fdf0-4d0c-be4e-47414fceaf99", "004938fa-d152-4d77-80fa-9ebd905e6175" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "86bafafe-3271-467f-b6ea-32967995ac65", "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "932ab41a-fdf0-4d0c-be4e-47414fceaf99", "004938fa-d152-4d77-80fa-9ebd905e6175" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86bafafe-3271-467f-b6ea-32967995ac65", "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "004938fa-d152-4d77-80fa-9ebd905e6175");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65",
                column: "ConcurrencyStamp",
                value: "5d10cc4b-9572-428e-8add-ae3d841fa379");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                column: "ConcurrencyStamp",
                value: "a68b2603-50f7-4514-aca1-5ee24caf78ea");

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
    }
}
