using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65",
                column: "ConcurrencyStamp",
                value: "f77740b1-57ea-49ac-bd3a-e9c5c2ae7c7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                column: "ConcurrencyStamp",
                value: "9fb318af-33c5-456a-b975-4693bbdda149");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "004938fa-d152-4d77-80fa-9ebd905e6175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e64964fb-4884-4a8c-b48f-97a9f45031de", "AQAAAAEAACcQAAAAEJki+OGODjiRS9Cf5QISsj2jA/FvF6m2UAS+71lYt5k6GWmleo6jM8TGzfY6e0cwlw==", "53cd28d0-5838-4e72-aac1-bd50599ece0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a2ad50-fa44-4715-b55f-16520917d4f9", "AQAAAAEAACcQAAAAEJvZu9HBrv859//gSdYzaufJj6btwkdhPdbV1pTfOUT4ktYjs4203yv+m0PzOyAJpQ==", "7fb8dd48-51a7-4a1c-8323-9d6775c0e3f5" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 123, DateTimeKind.Local).AddTicks(7148), new DateTime(2021, 12, 15, 8, 41, 49, 126, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 126, DateTimeKind.Local).AddTicks(9095), new DateTime(2021, 12, 15, 8, 41, 49, 126, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 126, DateTimeKind.Local).AddTicks(9112), new DateTime(2021, 12, 15, 8, 41, 49, 126, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(1617), new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(1666), new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4912), new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4931), new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4937), new DateTime(2021, 12, 15, 8, 41, 49, 128, DateTimeKind.Local).AddTicks(4939) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "004938fa-d152-4d77-80fa-9ebd905e6175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82a4dbd-dc6d-42b8-bad4-01c274622cf0", "AQAAAAEAACcQAAAAEKt4vejQoae2ufAa0wuF+HFns85Jt+wCOvxlKJHDlzbCe5HhG9fb7byAuiDE594kfA==", "ee68e515-dc44-4ce3-a77b-932fe5bbbd42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b0ba62c-a798-450e-946e-163fb0131ed1", "AQAAAAEAACcQAAAAENv3G26hE+I30s897RwK/uEaxvcmUK4e0y8+P95AYFm6XFgT2ygXr1oz99nYAaqb+Q==", "f2830e77-b671-43d6-9fd0-a7a8010a72e5" });

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
        }
    }
}
