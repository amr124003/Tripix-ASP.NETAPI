using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class EditProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverlicenseImage");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "VehicleImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DriverLicense",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverLicense",
                table: "Drivers");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "VehicleImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DriverlicenseImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverlicenseImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverlicenseImage_Drivers_DriverId1",
                        column: x => x.DriverId1,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DriverlicenseImage_DriverId1",
                table: "DriverlicenseImage",
                column: "DriverId1");
        }
    }
}
