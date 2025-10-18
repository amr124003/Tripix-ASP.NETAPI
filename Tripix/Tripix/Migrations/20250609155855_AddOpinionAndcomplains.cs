using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddOpinionAndcomplains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerOpinion_AspNetUsers_UserId",
                table: "PassengerOpinion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PassengerOpinion",
                table: "PassengerOpinion");

            migrationBuilder.DropIndex(
                name: "IX_PassengerOpinion_UserId",
                table: "PassengerOpinion");

            migrationBuilder.RenameTable(
                name: "PassengerOpinion",
                newName: "passengerOpinions");

            migrationBuilder.AlterColumn<int>(
                name: "CompleltedSteps",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AcceptCount",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CancellationCount",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DriverId",
                table: "passengerOpinions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengerOpinions",
                table: "passengerOpinions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Complains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ComplainContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complains_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RateValue = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rating_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_passengerOpinions_DriverId",
                table: "passengerOpinions",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_passengerOpinions_UserId",
                table: "passengerOpinions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_UserId",
                table: "Complains",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_DriverId",
                table: "Rating",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId",
                table: "Rating",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_passengerOpinions_AspNetUsers_UserId",
                table: "passengerOpinions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_passengerOpinions_Drivers_DriverId",
                table: "passengerOpinions",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengerOpinions_AspNetUsers_UserId",
                table: "passengerOpinions");

            migrationBuilder.DropForeignKey(
                name: "FK_passengerOpinions_Drivers_DriverId",
                table: "passengerOpinions");

            migrationBuilder.DropTable(
                name: "Complains");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengerOpinions",
                table: "passengerOpinions");

            migrationBuilder.DropIndex(
                name: "IX_passengerOpinions_DriverId",
                table: "passengerOpinions");

            migrationBuilder.DropIndex(
                name: "IX_passengerOpinions_UserId",
                table: "passengerOpinions");

            migrationBuilder.DropColumn(
                name: "AcceptCount",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CancellationCount",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "passengerOpinions");

            migrationBuilder.RenameTable(
                name: "passengerOpinions",
                newName: "PassengerOpinion");

            migrationBuilder.AlterColumn<int>(
                name: "CompleltedSteps",
                table: "Drivers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PassengerOpinion",
                table: "PassengerOpinion",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerOpinion_UserId",
                table: "PassengerOpinion",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerOpinion_AspNetUsers_UserId",
                table: "PassengerOpinion",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
