using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "SparePartOrders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SparePartOrders_ApplicationUserId",
                table: "SparePartOrders",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SparePartOrders_AspNetUsers_ApplicationUserId",
                table: "SparePartOrders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SparePartOrders_AspNetUsers_ApplicationUserId",
                table: "SparePartOrders");

            migrationBuilder.DropIndex(
                name: "IX_SparePartOrders_ApplicationUserId",
                table: "SparePartOrders");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "SparePartOrders");
        }
    }
}
