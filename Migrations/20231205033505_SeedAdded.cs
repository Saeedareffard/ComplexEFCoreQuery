using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PracticeLinq.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cusotmers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cusotmers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Cusotmers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Cusotmers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cusotmers",
                columns: new[] { "CustomerID", "Name" },
                values: new object[,]
                {
                    { 1, "Saeed" },
                    { 2, "Alex" },
                    { 3, "James" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Name" },
                values: new object[,]
                {
                    { 101, "Widget A" },
                    { 102, "Widget B" },
                    { 103, "Widget C" },
                    { 104, "Widget D" },
                    { 105, "Widget E" },
                    { 106, "Widget F" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "OrderDate" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 2, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 3, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 3, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 3, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 2, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 3, 103, 5 },
                    { 3, 104, 3 },
                    { 4, 105, 2 },
                    { 4, 106, 4 },
                    { 5, 101, 1 },
                    { 5, 102, 2 },
                    { 6, 103, 3 },
                    { 6, 104, 1 },
                    { 7, 105, 4 },
                    { 7, 106, 2 },
                    { 8, 101, 3 },
                    { 8, 102, 5 },
                    { 9, 103, 2 },
                    { 9, 104, 1 },
                    { 10, 105, 3 },
                    { 10, 106, 2 },
                    { 11, 101, 4 },
                    { 11, 102, 1 },
                    { 12, 103, 5 },
                    { 12, 104, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cusotmers");
        }
    }
}
