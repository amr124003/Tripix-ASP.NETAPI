using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Content", "Date", "Image", "Location", "Title" },
                values: new object[] { 1, "This Event Is For All Users You Can Now Book Ticket And Take It To Meet Most And Important Car Character", new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/Events/DALL·E 2025-02-08 05.45.57 - A vibrant car event during the daytime, with people gathered around modern and classic cars, enjoying the atmosphere under a sunny blue sky. The scene.webp", "Egypt International Exhibition Center", "Cairo Motor Show 2025" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
