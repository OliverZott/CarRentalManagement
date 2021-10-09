using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 9, 15, 46, 42, 937, DateTimeKind.Local).AddTicks(1802), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(4132), "Black", "System" },
                    { 2, "System", new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5131), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5144), "Red", "System" },
                    { 3, "System", new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5149), new DateTime(2021, 10, 9, 15, 46, 42, 939, DateTimeKind.Local).AddTicks(5151), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8433), new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8453), "Opel", "System" },
                    { 2, "System", new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8458), new DateTime(2021, 10, 9, 15, 46, 42, 940, DateTimeKind.Local).AddTicks(8461), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1724), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1739), "Astra", "System" },
                    { 2, "System", new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1744), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1746), "X5", "System" },
                    { 3, "System", new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1750), new DateTime(2021, 10, 9, 15, 46, 42, 941, DateTimeKind.Local).AddTicks(1752), "M3", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
