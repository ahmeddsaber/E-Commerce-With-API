using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class init31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Catogeries",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "Name", "ProductId", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6068), "System", "Devices and gadgets", null, "Electronics", 0, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6071), "System", false },
                    { 2, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6073), "System", "Men and Women Clothes", null, "Clothes", 0, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6074), "System", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatogeryId", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6198), "System", "Gaming Laptop", null, "Laptop", 25000m, 5, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6199), "System", false },
                    { 2, 2, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6205), "System", "Cotton T-Shirt", null, "T-Shirt", 250m, 50, new DateTime(2025, 10, 30, 3, 20, 8, 549, DateTimeKind.Utc).AddTicks(6205), "System", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catogeries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Products");
        }
    }
}
