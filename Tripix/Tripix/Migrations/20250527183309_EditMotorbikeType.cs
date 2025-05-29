using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditMotorbikeType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ElectricCars_Gearbox_Type",
                table: "Vehicles",
                newName: "ElectricCars_Merchant_Phone");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Car_CreatedAt",
                table: "Vehicles",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Car_Merchant_Logo",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Car_Merchant_Name",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Car_Merchant_Phone",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "ElectricCars_CreatedAt",
                table: "Vehicles",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricCars_Merchant_Logo",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElectricCars_Merchant_Name",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/Teacher Motors.WEBP", "Teacher Motors", "0114585330" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ElectricCars_CreatedAt", "ElectricCars_Merchant_Logo", "ElectricCars_Merchant_Name", "ElectricCars_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ElectricCars_CreatedAt", "ElectricCars_Merchant_Logo", "ElectricCars_Merchant_Name", "ElectricCars_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car_CreatedAt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Car_Merchant_Logo",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Car_Merchant_Name",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Car_Merchant_Phone",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ElectricCars_CreatedAt",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ElectricCars_Merchant_Logo",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ElectricCars_Merchant_Name",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "ElectricCars_Merchant_Phone",
                table: "Vehicles",
                newName: "ElectricCars_Gearbox_Type");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/Teacher Motors.WEBP", "Teacher Motors", "0114585330" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ElectricCars_Gearbox_Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ElectricCars_Gearbox_Type",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });
        }
    }
}
