using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_Management__System.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    SellingPrice = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Groceries" },
                    { 3, "Clothing" },
                    { 4, "Books" },
                    { 5, "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ProductName", "SellingPrice" },
                values: new object[,]
                {
                    { 1, 1, "15-inch laptop with 8GB RAM", "Laptop", 999.99m },
                    { 2, 1, "Latest model smartphone with 128GB storage", "Smartphone", 699.99m },
                    { 3, 3, "Comfortable blue jeans", "Jeans", 49.99m },
                    { 4, 5, "LED desk lamp with adjustable brightness", "Desk Lamp", 29.99m },
                    { 5, 2, "Whole grain cereal, 500g box", "Cereal", 3.99m }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 50 },
                    { 2, 2, 100 },
                    { 3, 3, 200 },
                    { 4, 4, 150 },
                    { 5, 5, 300 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Notes", "ProductID", "Quantity", "TransactionDate", "TransactionType" },
                values: new object[,]
                {
                    { 1, "Initial stock purchase", 1, 50, new DateTime(2024, 8, 15, 13, 20, 11, 661, DateTimeKind.Local).AddTicks(211), "Purchase" },
                    { 2, "Initial stock purchase", 2, 100, new DateTime(2024, 8, 17, 13, 20, 11, 661, DateTimeKind.Local).AddTicks(260), "Purchase" },
                    { 3, "Initial stock purchase", 3, 200, new DateTime(2024, 8, 19, 13, 20, 11, 661, DateTimeKind.Local).AddTicks(264), "Purchase" },
                    { 4, "Initial stock purchase", 4, 150, new DateTime(2024, 8, 20, 13, 20, 11, 661, DateTimeKind.Local).AddTicks(266), "Purchase" },
                    { 5, "Sale to customer", 5, 30, new DateTime(2024, 8, 22, 13, 20, 11, 661, DateTimeKind.Local).AddTicks(269), "Sale" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductID",
                table: "Inventories",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductID",
                table: "Transactions",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
