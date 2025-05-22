using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdatecarData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "FavouriteProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "FavouriteProduct",
                newName: "VehicleId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId1",
                table: "FavouriteProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProduct_VehicleId1",
                table: "FavouriteProduct",
                column: "VehicleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProduct_Vehicles_VehicleId1",
                table: "FavouriteProduct",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProduct_Vehicles_VehicleId1",
                table: "FavouriteProduct");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProduct_VehicleId1",
                table: "FavouriteProduct");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "FavouriteProduct");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "FavouriteProduct",
                newName: "ProductId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "FavouriteProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "LikeCounter", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "Status", "VehicleType", "Year" },
                values: new object[] { 23, "SUV", "blask", "New", null, "Audi Q3 sportback 2024\r\nExterior Color: Grey\r\nInterior: Black x red \r\nCondition: Brand New\r\nEngine: 1.5L\r\nHorse power:150 hp\r\n8-Speed Automatic Transmission\r\nAcceleration:0-100 km/h 9.2 sec\r\nLED Headlights\r\nElectrically Folding Exterior Mirrors\r\nFully Parking Sensors\r\nRim 19 inch\r\nSunroof\r\nElectric seats with memory package\r\nElectric tailgate\r\nWelcome lights\r\n360° Camera\r\n6 Airbags\r\n30-color Ambient Lighting\r\nVery special specs and color\r\nImmediate purchase\r\nFor reservations and inquiries contact us ", null, "Automatic", 0, "/Images/TripixLogo.png", "Tripix", "01020652199", "CLE 200", "2000 CC", "Mercedes Cle 200 AMG 2024", "Mercedes-Benz", 1850000m, 5, "Avilable", "Car", "2024" });
        }
    }
}
