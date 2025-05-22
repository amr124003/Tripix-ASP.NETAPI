using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarsValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "CarLocation_Latitude",
                table: "Vehicles",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CarLocation_Longitude",
                table: "Vehicles",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ElectricCars_Gearbox_Type", "Status" },
                values: new object[] { null, "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ElectricCars_Gearbox_Type", "Status" },
                values: new object[] { null, "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                column: "Status",
                value: "Avilable");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Automatic", "Avilable" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                column: "Status",
                value: "Avilable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarLocation_Latitude",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CarLocation_Longitude",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ElectricCars_Gearbox_Type", "Status" },
                values: new object[] { "Automatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ElectricCars_Gearbox_Type", "Status" },
                values: new object[] { "Automatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Gearbox_Type", "Status" },
                values: new object[] { "Autohmatic", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                column: "Status",
                value: 1);
        }
    }
}
