using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairBookings_AspNetUsers_UserId",
                table: "RepairBookings");

            migrationBuilder.DropIndex(
                name: "IX_RepairBookings_UserId",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "UserAddress",
                table: "HelpooOrders");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "RepairBookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PricingPlan",
                table: "RepairBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderTime",
                table: "HelpooOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "UserLatitude",
                table: "HelpooOrders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UserLongitude",
                table: "HelpooOrders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_RepairBookings_ApplicationUserId",
                table: "RepairBookings",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairBookings_AspNetUsers_ApplicationUserId",
                table: "RepairBookings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairBookings_AspNetUsers_ApplicationUserId",
                table: "RepairBookings");

            migrationBuilder.DropIndex(
                name: "IX_RepairBookings_ApplicationUserId",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "PricingPlan",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "OrderTime",
                table: "HelpooOrders");

            migrationBuilder.DropColumn(
                name: "UserLatitude",
                table: "HelpooOrders");

            migrationBuilder.DropColumn(
                name: "UserLongitude",
                table: "HelpooOrders");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RepairBookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAddress",
                table: "HelpooOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_RepairBookings_UserId",
                table: "RepairBookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairBookings_AspNetUsers_UserId",
                table: "RepairBookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
