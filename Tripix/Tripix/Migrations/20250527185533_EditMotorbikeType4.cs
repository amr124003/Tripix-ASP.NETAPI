using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditMotorbikeType4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoadCapacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TruckType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Truck_Motor_Capacity",
                table: "Vehicles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LoadCapacity",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TruckType",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Truck_Motor_Capacity",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
