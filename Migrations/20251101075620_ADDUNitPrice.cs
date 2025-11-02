using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class ADDUNitPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UnitPrice", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1774), 300m, new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1739), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1149), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1162), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1689), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1695), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1633), new DateTime(2025, 11, 1, 9, 56, 15, 757, DateTimeKind.Local).AddTicks(1637), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1493), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1504), new DateTime(2025, 11, 1, 7, 56, 15, 757, DateTimeKind.Utc).AddTicks(1505) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "CartItems");

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
    }
}
