using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Models",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Makes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Colours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "4377eab1-00cf-4cc2-9358-59ff60a6f8af", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "bfbda258-457f-4a05-b2ad-202d14a579b0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 27, 22, 46, 5, 689, DateTimeKind.Local).AddTicks(4044), new DateTime(2022, 11, 27, 22, 46, 5, 690, DateTimeKind.Local).AddTicks(9326), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 27, 22, 46, 5, 690, DateTimeKind.Local).AddTicks(9953), new DateTime(2022, 11, 27, 22, 46, 5, 690, DateTimeKind.Local).AddTicks(9957), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(1554), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(1559), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4256), "System" },
                    { 2, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4261), "System" },
                    { 3, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4264), "System" },
                    { 4, "System", new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 11, 27, 22, 46, 5, 692, DateTimeKind.Local).AddTicks(4266), "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Makes");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Bookings");
        }
    }
}
