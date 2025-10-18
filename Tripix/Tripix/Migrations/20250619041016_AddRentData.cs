using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddRentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarsForrRents",
                columns: new[] { "Id", "CarColor", "CarDescription", "CarImage", "CarModel", "CarName", "CarRate", "HourlyPrice", "Status" },
                values: new object[] { 1, "Black", "That Car Is Rented For One Day Only", "/Images/Cars/Kia EV5 2024 1.WEBP", "EV5", "Kia EV5 2024", 3, 100m, "Avilable" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
