using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddPricingPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings");

            migrationBuilder.AddColumn<string>(
                name: "PricingPlan",
                table: "WashBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings");

            migrationBuilder.DropColumn(
                name: "PricingPlan",
                table: "WashBookings");

            migrationBuilder.AddForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
