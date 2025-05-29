using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "WashBookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "HelpooOrders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WashBookings_ApplicationUserId",
                table: "WashBookings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpooOrders_ApplicationUserId",
                table: "HelpooOrders",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpooOrders_AspNetUsers_ApplicationUserId",
                table: "HelpooOrders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpooOrders_AspNetUsers_ApplicationUserId",
                table: "HelpooOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_WashBookings_AspNetUsers_ApplicationUserId",
                table: "WashBookings");

            migrationBuilder.DropIndex(
                name: "IX_WashBookings_ApplicationUserId",
                table: "WashBookings");

            migrationBuilder.DropIndex(
                name: "IX_HelpooOrders_ApplicationUserId",
                table: "HelpooOrders");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "WashBookings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "HelpooOrders");
        }
    }
}
