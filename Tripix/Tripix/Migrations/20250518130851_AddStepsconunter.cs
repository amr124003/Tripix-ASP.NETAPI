using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddStepsconunter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RepairDate",
                table: "RepairBookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RepairBookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompleltedSteps",
                table: "Drivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "CarRents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CarRents",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_RepairBookings_UserId",
                table: "RepairBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRents_UserId",
                table: "CarRents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRents_AspNetUsers_UserId",
                table: "CarRents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairBookings_AspNetUsers_UserId",
                table: "RepairBookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRents_AspNetUsers_UserId",
                table: "CarRents");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairBookings_AspNetUsers_UserId",
                table: "RepairBookings");

            migrationBuilder.DropIndex(
                name: "IX_RepairBookings_UserId",
                table: "RepairBookings");

            migrationBuilder.DropIndex(
                name: "IX_CarRents_UserId",
                table: "CarRents");

            migrationBuilder.DropColumn(
                name: "RepairDate",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RepairBookings");

            migrationBuilder.DropColumn(
                name: "CompleltedSteps",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "CarRents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CarRents");
        }
    }
}
