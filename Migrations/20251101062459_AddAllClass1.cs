using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIGenerationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddAllClass1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[] { 1, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6871), "System", new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6871), "System", false });

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "OrderDate", "TotalAmount", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[] { 1, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6817), "System", new DateTime(2025, 11, 1, 8, 24, 54, 397, DateTimeKind.Local).AddTicks(6819), 25250m, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6817), "System", false });

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

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CartId", "CreatedAt", "CreatedBy", "ProductId", "Quantity", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[] { 1, 1, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6888), "System", 2, 2, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6888), "System", false });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "OrderId", "ProductId", "Quantity", "UnitPrice", "UpdatedAt", "UpdatedBy", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6846), "System", 1, 1, 1, 25000m, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6846), "System", false },
                    { 2, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6849), "System", 1, 2, 1, 250m, new DateTime(2025, 11, 1, 6, 24, 54, 397, DateTimeKind.Utc).AddTicks(6850), "System", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
