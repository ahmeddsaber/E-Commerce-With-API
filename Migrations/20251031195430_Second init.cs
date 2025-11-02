using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class Secondinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Catogeries");

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1035), new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1154), new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1160), new DateTime(2025, 10, 31, 19, 54, 22, 922, DateTimeKind.Utc).AddTicks(1161) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Catogeries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6068), null, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6073), null, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6198), null, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6205), null, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6205) });
        }
    }
}
