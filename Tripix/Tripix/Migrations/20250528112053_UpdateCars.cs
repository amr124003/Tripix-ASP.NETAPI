using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { "/Images/Teacher Motors.WEBP", "Teacher Motors", "0114585330" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { "/Images/TripixLogo.png", "Tripix", "01020652199" });
        }
    }
}
