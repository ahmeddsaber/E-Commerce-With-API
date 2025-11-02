using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddAllClass2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(552), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(468), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(160), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(166), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(445), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(448), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(419), new DateTime(2025, 11, 1, 8, 26, 56, 575, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(324), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(330), new DateTime(2025, 11, 1, 6, 26, 56, 575, DateTimeKind.Utc).AddTicks(330) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6888), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6871), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6436), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6443), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6846), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6849), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6817), new DateTime(2025, 11, 1, 8, 24, 54, 397, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6726), new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6727) });
        }
    }
}
