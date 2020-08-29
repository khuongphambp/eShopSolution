using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 29, 17, 43, 40, 663, DateTimeKind.Local).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 29, 17, 42, 33, 832, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("11efec09-12b2-47b2-8ef5-e1b0bd9c9627"),
                column: "ConcurrencyStamp",
                value: "964e2f0a-e7ce-487f-a94c-a09d4ff607e0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a4b0f3c1-6387-471a-a1aa-5af32a76cb59"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed44cd50-2230-4868-8e50-1854170e6a3f", "AQAAAAEAACcQAAAAEAeTHcOmWkbMZH4CJWLvrFgZ8oMfBfHfwQ6ZBJVKRcvaWOYxbKO4VgMo7CxLSmk6SA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 29, 17, 43, 40, 684, DateTimeKind.Local).AddTicks(6312));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 29, 17, 42, 33, 832, DateTimeKind.Local).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 29, 17, 43, 40, 663, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("11efec09-12b2-47b2-8ef5-e1b0bd9c9627"),
                column: "ConcurrencyStamp",
                value: "ab1937d6-60b0-4ab4-b72e-c689fbc01def");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a4b0f3c1-6387-471a-a1aa-5af32a76cb59"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ca8feb0-202f-48bc-b485-93b4d09853fd", "AQAAAAEAACcQAAAAENIe2biWuHF6XzyB8U2FK75SuSgg6nXYRwCJSjZmJ01EOwl041fMr37nEjam8Ku0NQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 29, 17, 42, 33, 853, DateTimeKind.Local).AddTicks(6780));
        }
    }
}
