using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LovedTips_AspNetUsers_UserId1",
                table: "LovedTips");

            migrationBuilder.DropIndex(
                name: "IX_LovedTips_UserId1",
                table: "LovedTips");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "LovedTips");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "LovedTips",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_LovedTips_UserId1",
                table: "LovedTips",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LovedTips_AspNetUsers_UserId1",
                table: "LovedTips",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
