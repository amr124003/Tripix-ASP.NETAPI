using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GovernateName",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "StartPrice",
                table: "Hotels",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Description", "EventId", "GovernateName", "Name", "Rate", "StartPrice" },
                values: new object[,]
                {
                    { 1, "1089 Corniche El Nil, Garden City, Cairo 11519, Egypt", "A luxurious hotel overlooking the Nile River, featuring spacious and elegantly furnished rooms, a world-class spa, multiple fine-dining restaurants, and proximity to the Egyptian Museum and downtown Cairo.", null, "Cairo", "Four Seasons Hotel Cairo at Nile Plaza", 4, 9870m },
                    { 2, "1115 Corniche El Nile, Bulaq, Downtown Cairo, Egypt", "A high-rise hotel with views of the Nile, casino, pool, gym, and easy access to Tahrir Square and the Egyptian Museum", null, "Cairo", "Ramses Hilton Hotel & Casino", 3, 5640m },
                    { 3, " 1189 Nile Corniche, Downtown Cairo, Egypt 11221", "Ultra-modern, luxury hotel with butler service, gourmet restaurants, pools, and a world-class spa", null, "Cairo", " The St. Regis Cairo", 4, 14100m },
                    { 4, "399 El Geish Road, San Stefano Grand Plaza, Alexandria 21599, Egypt", "A luxury resort-style hotel set between the Mediterranean Sea and the city. Features include a private beach, three pools (indoor heated and outdoor infinity), full spa (14 treatment rooms), squash court, multiple fine-dining restaurants, and beachfront access with spectacular sea views", null, "Alex", " Four Seasons Hotel Alexandria at San Stefano", 4, 14300m },
                    { 5, " Al Montazah Palace, Montazah Gardens, Alexandria, Egypt", "Historic beachfront hotel nestled in lush Montazah Gardens. Offers a private beach, outdoor pool, spa, fitness center, and several restaurants. Spacious, sea-facing balconies (some overlooking Montazah Palace). Surrounded by a serene garden reserve .", null, "Alex", "Helnan Royal Palestine Hotel – Montazah Gardens", 3, 5640m },
                    { 6, " 16 Saad Zagloul Square, Raml Station, Alexandria 11015, Egypt", "A classic 4-star historic hotel (opened in 1929), recently renovated. Located in downtown, steps from the Corniche and cultural landmarks. Offers free Wi‑Fi, restaurant, balconies, minibar, and multilingual staff", null, "Alex", "Steigenberger Cecil Alexandria Hotel", 3, 4230m },
                    { 7, " Yussif Afifi Road – El Mamsha El Seyahi, Hurghada", "A luxury 5-star, all-inclusive beachfront resort with outstanding service and family facilities", null, "Hurghada", "Steigenberger ALDAU Beach Hotel", 4, 11421m },
                    { 8, " Madinat Makadi area, Hurghada", "Features Egypt's largest water park (~50 rides), private beach, multiple pools, spa, kids' club, and buffet/a‑la‑carte dining", null, "Hurghada", "Jaz Aquaviva (formerly Jaz Aquaviva & Jaz Casa Del Mar Beach)", 4, 20586m },
                    { 9, " East Bank, Luxor", "A luxury 5-star resort with Nile views, outdoor pool, fitness center, spa, and on-site restaurants", null, "Luxor", "Steigenberger Nile Palace Luxor", 3, 3243m },
                    { 10, " East Bank, on the Nile, near Luxor Temple", "Iconic historic palace hotel (since 1907) with Victorian style, lush gardens, premium restaurants, and pool", null, "Luxor", "Sofitel Winter Palace Luxor", 4, 9870m }
                });

            migrationBuilder.InsertData(
                table: "HotleImages",
                columns: new[] { "Id", "HotelId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "Images/h11.jpg" },
                    { 2, 1, "Images/h12.jpg" },
                    { 3, 1, "Images/h13.jpg" },
                    { 4, 2, "Images/h21.jpg" },
                    { 5, 2, "Images/h22.jpg" },
                    { 6, 2, "Images/h23.jpg" },
                    { 7, 3, "Images/h31.jpg" },
                    { 8, 3, "Images/h32.jpg" },
                    { 9, 3, "Images/h33.jpg" },
                    { 10, 4, "Images/h41.jpg" },
                    { 11, 4, "Images/h42.jpg" },
                    { 12, 4, "Images/h43.jpg" },
                    { 13, 5, "Images/h51.jpg" },
                    { 14, 5, "Images/h52.jpg" },
                    { 15, 5, "Images/h53.jpg" },
                    { 16, 6, "Images/h61.jpg" },
                    { 17, 6, "Images/h62.jpg" },
                    { 18, 6, "Images/h63.jpg" },
                    { 19, 7, "Images/h71.jpg" },
                    { 20, 7, "Images/h72.jpg" },
                    { 21, 7, "Images/h73.jpg" },
                    { 22, 8, "Images/h81.jpg" },
                    { 23, 8, "Images/h82.jpg" },
                    { 24, 8, "Images/h83.jpg" },
                    { 25, 9, "Images/h91.jpg" },
                    { 26, 9, "Images/h92.jpg" },
                    { 27, 9, "Images/h93.jpg" },
                    { 28, 10, "Images/h101.jpg" },
                    { 29, 10, "Images/h102.jpg" },
                    { 30, 10, "Images/h103.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HotleImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "GovernateName",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StartPrice",
                table: "Hotels");
        }
    }
}
