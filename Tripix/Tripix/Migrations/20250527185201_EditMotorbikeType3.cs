using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditMotorbikeType3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Car_Discount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Car_Rate",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ElectricCars_Discount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ElectricCars_Rate",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Motorbikes_Discount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Motorbikes_Rate",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Discount", "Rate" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Car_Discount",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Car_Rate",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ElectricCars_Discount",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElectricCars_Rate",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Motorbikes_Discount",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Motorbikes_Rate",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ElectricCars_Discount", "ElectricCars_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ElectricCars_Discount", "ElectricCars_Rate" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Car_Discount", "Car_Rate" },
                values: new object[] { null, 5 });
        }
    }
}
