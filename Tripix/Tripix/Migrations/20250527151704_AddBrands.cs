using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class AddBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Expand", "Name", "NameAR", "VehicleType" },
                values: new object[,]
                {
                    { 54, false, "Harley-Davidson", "هارلي ديفيدسون", 1 },
                    { 55, false, "Yamaha", "ياماها", 1 },
                    { 56, false, "Honda", "هوندا", 1 },
                    { 57, false, "Kawasaki", "كاواساكي", 1 },
                    { 58, false, "Suzuki", "سوزوكي", 1 },
                    { 59, false, "BMW Motorrad", "بي إم دبليو موتو", 1 },
                    { 60, false, "Ducati", "دوكاتي", 1 },
                    { 61, false, "KTM", "كي تي إم", 1 },
                    { 62, false, "Bajaj", "باجاج", 1 },
                    { 63, false, "Hero", "هيرو", 1 },
                    { 64, false, "TVS", "تي في إس", 1 },
                    { 65, false, "Royal Enfield", "رويال إنفيلد", 1 },
                    { 66, false, "Aprilia", "أبريليا", 1 },
                    { 67, false, "Benelli", "بينيللي", 1 },
                    { 68, false, "CFMoto", "سي إف موتو", 1 },
                    { 69, false, "Vespa", "فيسبا", 1 },
                    { 70, false, "SYM", "إس واي إم", 1 },
                    { 71, false, "Lifan", "ليفان", 1 },
                    { 72, false, "Zontes", "زونتس", 1 },
                    { 73, false, "Nissan Leaf", "نيسان ليف", 2 },
                    { 74, false, "Chevrolet Bolt", "شيفروليه بولت", 2 },
                    { 75, false, "BMW i", "بي إم دبليو آي", 2 },
                    { 76, false, "Audi e-tron", "أودي إي ترون", 2 },
                    { 77, false, "Jaguar I-Pace", "جاكوار آي-بيس", 2 },
                    { 78, false, "Rivian", "ريفيان", 2 },
                    { 79, false, "Lucid Motors", "لوسيد موتورز", 2 },
                    { 80, false, "NIO", "نيو", 2 },
                    { 81, false, "XPeng", "إكس بنج", 2 },
                    { 82, false, "Polestar", "بولستار", 2 },
                    { 83, false, "Faraday Future", "فاراداي فيوتشر", 2 },
                    { 84, false, "Tesla", "تسلا", 2 },
                    { 85, false, "VinFast", "فينفاست", 2 }
                });

            migrationBuilder.InsertData(
                table: "CarModel",
                columns: new[] { "Id", "BrandId", "Name", "NameAR" },
                values: new object[,]
                {
                    { 276, 54, "Street 750", "ستريت 750" },
                    { 277, 54, "Iron 883", "آيرون 883" },
                    { 278, 54, "Fat Bob", "فات بوب" },
                    { 279, 54, "Sportster S", "سبورتستر S" },
                    { 280, 55, "YZF-R1", "واي زد إف R1" },
                    { 281, 55, "MT-07", "إم تي 07" },
                    { 282, 55, "NMAX", "إن ماكس" },
                    { 283, 55, "FZ25", "إف زد 25" },
                    { 284, 56, "CBR500R", "سي بي آر 500 آر" },
                    { 285, 56, "CB650R", "سي بي 650 آر" },
                    { 286, 56, "Rebel 500", "ريبل 500" },
                    { 287, 56, "Africa Twin", "أفريكا توين" },
                    { 288, 57, "R1250GS", "آر 1250 جي إس" },
                    { 289, 57, "G310R", "جي 310 آر" },
                    { 290, 57, "F900R", "إف 900 آر" },
                    { 291, 58, "Duke 390", "ديوك 390" },
                    { 292, 58, "RC 200", "آر سي 200" },
                    { 293, 58, "1290 Super Duke R", "1290 سوبر ديوك آر" },
                    { 294, 59, "Panigale V4", "بانيجالي V4" },
                    { 295, 59, "Monster 937", "مونستر 937" },
                    { 296, 59, "Multistrada V4", "مولتسترادا V4" },
                    { 297, 60, "Pulsar 220F", "بولسار 220 إف" },
                    { 298, 60, "Dominar 400", "دومينار 400" },
                    { 299, 60, "Platina", "بلاتينا" },
                    { 300, 61, "Apache RTR 160", "أباتشي RTR 160" },
                    { 301, 61, "NTorq 125", "إن تورك 125" },
                    { 302, 61, "Raider 125", "رايدر 125" },
                    { 303, 71, "KPR 150", "كي بي آر 150" },
                    { 304, 71, "KPR 200", "كي بي آر 200" },
                    { 305, 71, "KP Mini 110", "كي بي ميني 110" },
                    { 306, 71, "LF150-10", "إل إف 150-10" },
                    { 307, 71, "LF200-23", "إل إف 200-23" },
                    { 308, 72, "Zontes 310R", "زونتس 310 آر" },
                    { 309, 72, "Zontes 310X", "زونتس 310 إكس" },
                    { 310, 72, "Zontes 250", "زونتس 250" },
                    { 311, 72, "Zontes 125-U", "زونتس 125-يو" },
                    { 312, 73, "Leaf S", "ليف إس" },
                    { 313, 73, "Leaf SV", "ليف إس في" },
                    { 314, 73, "Altima", "ألتيما" },
                    { 315, 73, "Rogue", "روغ" },
                    { 316, 74, "Bolt EV", "بولت إي في" },
                    { 317, 74, "Bolt EUV", "بولت إيوي" },
                    { 318, 74, "Malibu", "ماليبو" },
                    { 319, 74, "Tahoe", "تاهو" },
                    { 320, 75, "i3", "آي 3" },
                    { 321, 75, "iX", "آي إكس" },
                    { 322, 75, "X5", "إكس 5" },
                    { 323, 75, "3 Series", "3 سيريز" },
                    { 324, 76, "e-tron", "إي ترون" },
                    { 325, 76, "e-tron GT", "إي ترون جي تي" },
                    { 326, 76, "Q5", "كيو 5" },
                    { 327, 76, "A4", "إيه 4" },
                    { 328, 77, "I-Pace", "آي-بيس" },
                    { 329, 77, "XF", "إكس إف" },
                    { 330, 78, "R1T", "آر1 تي" },
                    { 331, 78, "R1S", "آر1 إس" },
                    { 332, 79, "Air", "آير" },
                    { 333, 80, "ES8", "إي إس8" },
                    { 334, 80, "ES6", "إي إس6" },
                    { 335, 81, "P7", "بي7" },
                    { 336, 81, "G3", "جي3" },
                    { 337, 82, "Polestar 2", "بولستار 2" },
                    { 338, 83, "FF 91", "إف إف 91" },
                    { 339, 84, "Model S", "موديل إس" },
                    { 340, 84, "Model 3", "موديل 3" },
                    { 341, 84, "Model X", "موديل إكس" },
                    { 342, 84, "Model Y", "موديل واي" },
                    { 343, 85, "VF e34", "في إف إي 34" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "CarModel",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Expand", "Name", "NameAR", "VehicleType" },
                values: new object[,]
                {
                    { 45, false, "Tesla", "تسلا", 0 },
                    { 46, false, "Rivian", "ريفيان", 0 },
                    { 53, false, "VinFast", "فينفاست", 0 }
                });
        }
    }
}
