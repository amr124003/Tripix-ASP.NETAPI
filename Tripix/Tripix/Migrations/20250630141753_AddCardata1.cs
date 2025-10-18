using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddCardata1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarImage",
                value: "/Images/CarForRent/car1.png");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarImage",
                value: "/Images/CarForRent/car2.png");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarImage",
                value: "/Images/CarForRent/car3.png");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CarImage",
                value: "/Images/CarForRent/car4.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarImage",
                value: "/Images/CarForRent/car1");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarImage",
                value: "/Images/CarForRent/car2");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarImage",
                value: "/Images/CarForRent/car3");

            migrationBuilder.UpdateData(
                table: "CarsForrRents",
                keyColumn: "Id",
                keyValue: 5,
                column: "CarImage",
                value: "/Images/CarForRent/car4");
        }
    }
}
