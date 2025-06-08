using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImagename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImages_SpareParts_SparePartsId",
                table: "VehicleImages");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImages_SparePartsId",
                table: "VehicleImages");

            migrationBuilder.DropColumn(
                name: "SparePartsId",
                table: "VehicleImages");

            migrationBuilder.AddColumn<string>(
                name: "SparePartImage",
                table: "SparePartOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SparePartImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartId = table.Column<int>(type: "int", nullable: false),
                    SparePartsId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SparePartImage_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SparePartImage_SparePartsId",
                table: "SparePartImage",
                column: "SparePartsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SparePartImage");

            migrationBuilder.DropColumn(
                name: "SparePartImage",
                table: "SparePartOrders");

            migrationBuilder.AddColumn<int>(
                name: "SparePartsId",
                table: "VehicleImages",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 181,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 182,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 183,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 184,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 185,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 186,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 187,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 188,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 189,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 190,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 191,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 192,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 193,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 194,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 195,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 196,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 197,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 198,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 199,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 200,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 201,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 202,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 203,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 204,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 205,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 206,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 207,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 208,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 209,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 210,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 211,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 212,
                column: "SparePartsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 213,
                column: "SparePartsId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_SparePartsId",
                table: "VehicleImages",
                column: "SparePartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImages_SpareParts_SparePartsId",
                table: "VehicleImages",
                column: "SparePartsId",
                principalTable: "SpareParts",
                principalColumn: "Id");
        }
    }
}
