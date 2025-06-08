using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddJopApplicationRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JopId",
                table: "JopApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "JopApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "JopApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JopApplications_JopId",
                table: "JopApplications",
                column: "JopId");

            migrationBuilder.CreateIndex(
                name: "IX_JopApplications_UserId1",
                table: "JopApplications",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JopApplications_AspNetUsers_UserId1",
                table: "JopApplications",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JopApplications_Jops_JopId",
                table: "JopApplications",
                column: "JopId",
                principalTable: "Jops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JopApplications_AspNetUsers_UserId1",
                table: "JopApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JopApplications_Jops_JopId",
                table: "JopApplications");

            migrationBuilder.DropIndex(
                name: "IX_JopApplications_JopId",
                table: "JopApplications");

            migrationBuilder.DropIndex(
                name: "IX_JopApplications_UserId1",
                table: "JopApplications");

            migrationBuilder.DropColumn(
                name: "JopId",
                table: "JopApplications");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "JopApplications");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "JopApplications");
        }
    }
}
