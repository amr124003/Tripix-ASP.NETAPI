using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId1",
                table: "FavouriteProducts");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProducts_VehicleId1",
                table: "FavouriteProducts");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "FavouriteProducts");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "FavouriteProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProducts_VehicleId",
                table: "FavouriteProducts",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId",
                table: "FavouriteProducts",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId",
                table: "FavouriteProducts");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProducts_VehicleId",
                table: "FavouriteProducts");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleId",
                table: "FavouriteProducts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId1",
                table: "FavouriteProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProducts_VehicleId1",
                table: "FavouriteProducts",
                column: "VehicleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId1",
                table: "FavouriteProducts",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
