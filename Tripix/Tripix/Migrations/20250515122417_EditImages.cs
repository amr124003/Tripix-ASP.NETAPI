using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 37);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VehicleImages",
                columns: new[] { "Id", "DriverId", "DriverId1", "ImageUrl", "SparePartsId", "VehicleId" },
                values: new object[] { 37, null, null, "/Images/Cars/Mercedes Benz E200 1.WEBP", null, 5 });
        }
    }
}
