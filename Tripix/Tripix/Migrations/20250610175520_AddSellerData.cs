using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddSellerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SellerEmail",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerPhone",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FuelType", "SellerEmail", "SellerName", "SellerPhone" },
                values: new object[] { "Fuel", "tripixv911@gmail.com", "Tripix", "01557373720" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellerEmail",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SellerName",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "SellerPhone",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                column: "FuelType",
                value: "Benzine");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                column: "FuelType",
                value: "Benzine");
        }
    }
}
