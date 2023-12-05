using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeLinq.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID", "Quantity" },
                values: new object[] { 3, 105, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 105 });
        }
    }
}
