using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddCardata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarsForrRents",
                columns: new[] { "Id", "CarColor", "CarDescription", "CarImage", "CarModel", "CarName", "CarRate", "HourlyPrice", "Status" },
                values: new object[,]
                {
                    { 2, "White", "Comfortable sedan, fuel efficient, suitable for city rides.", "/Images/CarForRent/car1.png", "2022", "Toyota Corolla", 4, 120.00m, "Avilable" },
                    { 3, "Black", "Sporty design with full options and automatic transmission.", "/Images/CarForRent/car2.png", "2021", "Hyundai Elantra", 5, 130.00m, "Avilable" },
                    { 4, "Gray", "Compact SUV, great for families and long trips.", "/Images/CarForRent/car3.png", "2023", "Kia Sportage", 5, 180.00m, "Avilable" },
                    { 5, "Blue", "Spacious car with good trunk space, ideal for business trips.", "/Images/CarForRent/car4.png", "2020", "Chevrolet Malibu", 3, 100.00m, "Avilable" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
