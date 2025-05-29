using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditMotorbikeType2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ElectricCars_Merchant_Phone",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwenerAddress",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwenerEmail",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwenerImage",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwenerName",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "OwenerPhonenumber",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Merchant_Logo",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

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
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
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
                keyValue: 12,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
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
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Merchant_Logo", "Merchant_Name", "Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Merchant_Logo",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddColumn<string>(
                name: "ElectricCars_Merchant_Phone",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwenerAddress",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwenerEmail",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwenerImage",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwenerName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwenerPhonenumber",
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
                keyValue: 7,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

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
                keyValue: 12,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

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
                keyValue: 17,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Car_CreatedAt", "Car_Merchant_Logo", "Car_Merchant_Name", "Car_Merchant_Phone" },
                values: new object[] { null, "/Images/TripixLogo.png", "Tripix", "01020652199" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber" },
                values: new object[] { null, null, null, null, null });
        }
    }
}
