using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location_Latitude",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Location_Longitude",
                table: "Drivers");

            migrationBuilder.AddColumn<Point>(
                name: "Location",
                table: "Drivers",
                type: "geography",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Drivers");

            migrationBuilder.AddColumn<double>(
                name: "Location_Latitude",
                table: "Drivers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Location_Longitude",
                table: "Drivers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
