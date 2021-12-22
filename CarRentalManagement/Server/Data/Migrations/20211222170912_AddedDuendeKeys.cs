using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDuendeKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65",
                column: "ConcurrencyStamp",
                value: "bc68b74f-5631-4a3e-9fef-0cd8de58d95b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                column: "ConcurrencyStamp",
                value: "564e458b-489e-424b-a7ff-00b939af1857");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "004938fa-d152-4d77-80fa-9ebd905e6175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fe2bcd-5881-4ee6-9ebd-d51a5974405e", "AQAAAAEAACcQAAAAEJlk1IKh5NII90rdWU/2xX5W4LUQr4PR0Xm59VhhgYucdhUxocLl3K3ReiEZ0VferQ==", "81c08efc-f61d-4b9f-aec9-693d2b6f16d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23029b69-fd51-4d41-96a9-f1e9455d9c08", "AQAAAAEAACcQAAAAEKlGRqvlhvW81fYBENuXd2Ap3d1CMqPN60FQ7fGvG//cI3OVdG3wX62Eh9MPZOwHwA==", "c8f6078c-5bb5-4548-bfbb-777eed24bfd7" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2789), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2827), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2831), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3006), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3013), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3089), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3094), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 12, 22, 18, 9, 12, 129, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants");

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
    }
}
