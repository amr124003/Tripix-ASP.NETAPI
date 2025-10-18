using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LovedTips_Tips_TipId1",
                table: "LovedTips");

            migrationBuilder.DropIndex(
                name: "IX_LovedTips_TipId1",
                table: "LovedTips");

            migrationBuilder.DropColumn(
                name: "TipId1",
                table: "LovedTips");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipId1",
                table: "LovedTips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LovedTips_TipId1",
                table: "LovedTips",
                column: "TipId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LovedTips_Tips_TipId1",
                table: "LovedTips",
                column: "TipId1",
                principalTable: "Tips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
