using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddFavourite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProduct_AspNetUsers_ApplicationUserId",
                table: "FavouriteProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProduct_Vehicles_VehicleId1",
                table: "FavouriteProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavouriteProduct",
                table: "FavouriteProduct");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProduct_ApplicationUserId",
                table: "FavouriteProduct");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "FavouriteProduct");

            migrationBuilder.RenameTable(
                name: "FavouriteProduct",
                newName: "FavouriteProducts");

            migrationBuilder.RenameIndex(
                name: "IX_FavouriteProduct_VehicleId1",
                table: "FavouriteProducts",
                newName: "IX_FavouriteProducts_VehicleId1");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FavouriteProducts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavouriteProducts",
                table: "FavouriteProducts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProducts_UserId",
                table: "FavouriteProducts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProducts_AspNetUsers_UserId",
                table: "FavouriteProducts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId1",
                table: "FavouriteProducts",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProducts_AspNetUsers_UserId",
                table: "FavouriteProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProducts_Vehicles_VehicleId1",
                table: "FavouriteProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavouriteProducts",
                table: "FavouriteProducts");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProducts_UserId",
                table: "FavouriteProducts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FavouriteProducts");

            migrationBuilder.RenameTable(
                name: "FavouriteProducts",
                newName: "FavouriteProduct");

            migrationBuilder.RenameIndex(
                name: "IX_FavouriteProducts_VehicleId1",
                table: "FavouriteProduct",
                newName: "IX_FavouriteProduct_VehicleId1");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "FavouriteProduct",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavouriteProduct",
                table: "FavouriteProduct",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProduct_ApplicationUserId",
                table: "FavouriteProduct",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProduct_AspNetUsers_ApplicationUserId",
                table: "FavouriteProduct",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProduct_Vehicles_VehicleId1",
                table: "FavouriteProduct",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
