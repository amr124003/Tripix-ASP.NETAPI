using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditPropertiesName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "CarsForrRents",
                newName: "CarRate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CarsForrRents",
                newName: "CarName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "CarsForrRents",
                newName: "CarModel");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "CarsForrRents",
                newName: "CarImage");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CarsForrRents",
                newName: "CarDescription");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "CarsForrRents",
                newName: "CarColor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarRate",
                table: "CarsForrRents",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "CarName",
                table: "CarsForrRents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CarModel",
                table: "CarsForrRents",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "CarImage",
                table: "CarsForrRents",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "CarDescription",
                table: "CarsForrRents",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CarColor",
                table: "CarsForrRents",
                newName: "Color");
        }
    }
}
