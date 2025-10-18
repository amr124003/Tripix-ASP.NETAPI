using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarlicenseImage_Drivers_DriverId1",
                table: "CarlicenseImage");

            migrationBuilder.DropForeignKey(
                name: "FK_passengerOpinions_Drivers_DriverId",
                table: "passengerOpinions");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Drivers_DriverId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImages_Drivers_DriverId1",
                table: "VehicleImages");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.AlterColumn<string>(
                name: "DriverId1",
                table: "CarlicenseImage",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AcceptCount",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CancellationCount",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarDescription",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarModel",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompleltedSteps",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CriminalRecord",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverFaceID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverImage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverLicense",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Location_Latitude",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Location_Longitude",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RejectAfterAccept",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "AspNetUsers",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CarlicenseImage_AspNetUsers_DriverId1",
                table: "CarlicenseImage",
                column: "DriverId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passengerOpinions_AspNetUsers_DriverId",
                table: "passengerOpinions",
                column: "DriverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_DriverId",
                table: "Rating",
                column: "DriverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImages_AspNetUsers_DriverId1",
                table: "VehicleImages",
                column: "DriverId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarlicenseImage_AspNetUsers_DriverId1",
                table: "CarlicenseImage");

            migrationBuilder.DropForeignKey(
                name: "FK_passengerOpinions_AspNetUsers_DriverId",
                table: "passengerOpinions");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_DriverId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImages_AspNetUsers_DriverId1",
                table: "VehicleImages");

            migrationBuilder.DropColumn(
                name: "AcceptCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CancellationCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarDescription",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompleltedSteps",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CriminalRecord",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DriverFaceID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DriverImage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DriverLicense",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnrollDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_Latitude",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Location_Longitude",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RejectAfterAccept",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "DriverId1",
                table: "CarlicenseImage",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AcceptCount = table.Column<int>(type: "int", nullable: false),
                    CancellationCount = table.Column<int>(type: "int", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompleltedSteps = table.Column<int>(type: "int", nullable: false),
                    CriminalRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverFaceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RejectAfterAccept = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Latitude = table.Column<double>(type: "float", nullable: false),
                    Location_Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarlicenseImage_Drivers_DriverId1",
                table: "CarlicenseImage",
                column: "DriverId1",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_passengerOpinions_Drivers_DriverId",
                table: "passengerOpinions",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Drivers_DriverId",
                table: "Rating",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImages_Drivers_DriverId1",
                table: "VehicleImages",
                column: "DriverId1",
                principalTable: "Drivers",
                principalColumn: "Id");
        }
    }
}
