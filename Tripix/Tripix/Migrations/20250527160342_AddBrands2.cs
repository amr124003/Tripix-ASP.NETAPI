using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddBrands2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarModel",
                columns: new[] { "Id", "BrandId", "Name", "NameAR" },
                values: new object[,]
                {
                    { 344, 62, "Pulsar 150", "بولسار 150" },
                    { 345, 62, "Boxer X125", "بوكسر X125" },
                    { 346, 62, "Discover 125", "ديسكفر 125" },
                    { 347, 62, "Avenger Street 160", "أفنجر ستريت 160" },
                    { 348, 63, "Splendor Plus", "سبليندر بلس" },
                    { 349, 63, "HF Deluxe", "إتش إف ديلوكس" },
                    { 350, 63, "Glamour", "غلامور" },
                    { 351, 63, "Xtreme 160R", "إكستريم 160R" },
                    { 352, 64, "Apache RTR 160", "أباتشي RTR 160" },
                    { 353, 64, "Star City Plus", "ستار سيتي بلس" },
                    { 354, 64, "Sport", "سبورت" },
                    { 355, 64, "NTorq 125", "إن تورك 125" },
                    { 356, 65, "Classic 350", "كلاسيك 350" },
                    { 357, 65, "Bullet 350", "بُلت 350" },
                    { 358, 65, "Meteor 350", "ميتيور 350" },
                    { 359, 65, "Himalayan", "هيماﻻيان" },
                    { 360, 66, "SR 160", "إس آر 160" },
                    { 361, 66, "RS 660", "آر إس 660" },
                    { 362, 66, "Tuono 660", "تونو 660" },
                    { 363, 67, "TNT 135", "تي إن تي 135" },
                    { 364, 67, "502C", "502 سي" },
                    { 365, 67, "Imperiale 400", "إمبريالي 400" },
                    { 366, 68, "300NK", "300 إن كيه" },
                    { 367, 68, "650NK", "650 إن كيه" },
                    { 368, 68, "250SR", "250 إس آر" },
                    { 369, 69, "Primavera 150", "بريمافيرا 150" },
                    { 370, 69, "Sprint 150", "سبرينت 150" },
                    { 371, 69, "GTS Super 300", "جي تي إس سوبر 300" },
                    { 372, 70, "Jet 14", "جيت 14" },
                    { 373, 70, "Symphony ST", "سيمفوني إس تي" },
                    { 374, 70, "Cruisym 300", "كروزيم 300" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 374);
        }
    }
}
