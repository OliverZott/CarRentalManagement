using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedVehicleImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86bafafe-3271-467f-b6ea-32967995ac65",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932ab41a-fdf0-4d0c-be4e-47414fceaf99",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "004938fa-d152-4d77-80fa-9ebd905e6175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39126ca5-69a2-437f-9e4d-fd934181fcc0", "AQAAAAIAAYagAAAAEKQrUIvYo33VAeKD54lCIcrkf/gvbeQQIgzSB9P0wyOP1nnLdd3/Ik0Ad1KrP2FX8Q==", "31df55a1-4003-46cb-a2e0-536eb43b17e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53e7d87-f37e-4ac9-83fd-26dfbe1d032e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa8a9424-e4a0-4a88-bdbd-b5c4c7d320c5", "AQAAAAIAAYagAAAAEDiDasZSHh5RtvytjqFg6CTirmnliAfSCLKdJK0uPJjJn+F40BO89S7fc/BV62Bteg==", "0db3bb46-93f2-474a-b919-f2f34722000d" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(634), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(643), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(993), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 12, 22, 9, 6, 10, 665, DateTimeKind.Local).AddTicks(1010) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
        }
    }
}
