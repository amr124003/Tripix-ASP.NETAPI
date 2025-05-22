using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class hhhhhe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Trips",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
