using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class Secondinit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 20, 5, 41, 117, DateTimeKind.Utc).AddTicks(9892), new DateTime(2025, 10, 31, 20, 5, 41, 117, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 20, 5, 41, 117, DateTimeKind.Utc).AddTicks(9897), new DateTime(2025, 10, 31, 20, 5, 41, 117, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 20, 5, 41, 118, DateTimeKind.Utc).AddTicks(7), new DateTime(2025, 10, 31, 20, 5, 41, 118, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 31, 20, 5, 41, 118, DateTimeKind.Utc).AddTicks(13), new DateTime(2025, 10, 31, 20, 5, 41, 118, DateTimeKind.Utc).AddTicks(14) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
