using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipComments_TipComments_ParentCommentId",
                table: "TipComments");

            migrationBuilder.DropIndex(
                name: "IX_TipComments_ParentCommentId",
                table: "TipComments");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "TipComments");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "TipComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Replies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "TipComments");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Replies");

            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "TipComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipComments_ParentCommentId",
                table: "TipComments",
                column: "ParentCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipComments_TipComments_ParentCommentId",
                table: "TipComments",
                column: "ParentCommentId",
                principalTable: "TipComments",
                principalColumn: "Id");
        }
    }
}
