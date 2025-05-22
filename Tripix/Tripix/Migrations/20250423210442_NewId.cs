using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class NewId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_ApplicationUserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_AspNetUsers_UserId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_ApplicationUserId",
                table: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trip",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "RefreshTokens");

            migrationBuilder.RenameTable(
                name: "Trip",
                newName: "Trips");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_UserId",
                table: "Trips",
                newName: "IX_Trips_UserId");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "RefreshTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Pending",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserID",
                table: "RefreshTokens",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UserID",
                table: "RefreshTokens",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_AspNetUsers_UserId",
                table: "Trips",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_UserID",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_AspNetUsers_UserId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_UserID",
                table: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "RefreshTokens");

            migrationBuilder.RenameTable(
                name: "Trips",
                newName: "Trip");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_UserId",
                table: "Trip",
                newName: "IX_Trip_UserId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "RefreshTokens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Pending");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trip",
                table: "Trip",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_ApplicationUserId",
                table: "RefreshTokens",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_AspNetUsers_ApplicationUserId",
                table: "RefreshTokens",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_AspNetUsers_UserId",
                table: "Trip",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
