using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddLikeCCounter_Status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBookings");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                table: "Vehicles",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LikeCounter",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "VehicleBookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "LikeCounter", "Status" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LikeCounter", "Status" },
                values: new object[] { null, 0, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBookings",
                column: "VehicleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBookings");

            migrationBuilder.DropColumn(
                name: "LikeCounter",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Vehicles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Vehicles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "VehicleBookings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBookings_VehicleId",
                table: "VehicleBookings",
                column: "VehicleId");
        }
    }
}
