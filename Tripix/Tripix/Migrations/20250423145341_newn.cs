using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tripix.Migrations
{
    /// <inheritdoc />
    public partial class newn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxID",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType", "Color", "Condition", "Description", "FuelType", "Gearbox_Type", "KilometersDriven", "Model", "Motor_Capacity", "Name", "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber", "Prand", "Price", "UsedCondition", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 17, "SUV", "Gray", "Used", "BMW X6 M50i 2017\r\n4400cc\r\n523hp\r\nHarman/kardon sound system \r\nPanoramic sunroof \r\nHead-up display \r\nWireless Charger \r\nCamera 360 \r\nShifting paddles \r\nElectric seats with memory package \r\nFully loaded\r\nCheck our showroom to find your dream car. ", "Benzine", "Autohmatic", 170000, "X6", "4400 CC", "BMW X6 M50i2017", null, null, null, null, null, "BMW", 3000000m, "Like New", "UsedCar", "2017" },
                    { 18, "Coupe", "Black", "Used", "Jaguar f-type 2021 mti \r\n30.000km\r\n2000cc\r\n300Hp\r\nTop speed 250km/h\r\nAcceleration 5.7 km/h (s)\r\nR-dynamic\r\nMeridian sound system \r\nElectric seats \r\nPanoramic sunroof \r\nShifting paddles \r\nApple carplay\r\nAndroid auto\r\nAmbient lighting \r\nWelcome lights \r\nFull active sensors\r\nNavigation\r\nAll Maintenance in mti \r\nFor reservations and inquiries contact us\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\nYou can buy it in cash or in installments with all banks and companies starting from 20% without ani admin fees \r\nVisit our showroom", "Benzine", "Autohmatic", 30000, "F-type", "2000 CC", "Jaguar F-type 2021 mti", null, null, null, null, null, "Jaguar", 1500000m, "Like New", "UsedCar", "2021" },
                    { 19, "Sedan", "Black", "Used", "BMW 750 Li 2009\r\n\r\n•Engine: 4.4- liter twin turbo v8\r\n•Horse power: 400 hp\r\nspeech “ Hello BMW”\r\n•keyless entry \r\n•Panoramic sliding sunroof \r\n•fully sensors \r\n•Electric seats with memory package \r\n•Electric tailgate\r\n•Lane keep assist \r\n•Break assist \r\n•Soft close \r\n•Blind spot \r\n•Dual zone air conditions\r\n•Cruise control \r\n•fully loaded \r\n•Very special specs and color\r\nFor reservations and inquiries contact us ", "Benzine", "Autohmatic", 129000, "750", "4400 CC", "BMW 750 Li 2009", null, null, null, null, null, "BMW", 1400000m, "Like New", "UsedCar", "2009" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[] { 20, "SUV", "Gray", "New", null, "Audi Q3 sportback 2024\r\nExterior Color: Grey\r\nInterior: Black x red \r\nCondition: Brand New\r\nEngine: 1.5L\r\nHorse power:150 hp\r\n8-Speed Automatic Transmission\r\nAcceleration:0-100 km/h 9.2 sec\r\nLED Headlights\r\nElectrically Folding Exterior Mirrors\r\nFully Parking Sensors\r\nRim 19 inch\r\nSunroof\r\nElectric seats with memory package\r\nElectric tailgate\r\nWelcome lights\r\n360° Camera\r\n6 Airbags\r\n30-color Ambient Lighting\r\nVery special specs and color\r\nImmediate purchase\r\nFor reservations and inquiries contact us ", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "Q3", "1500 CC", "Audi Q3 sportback 2024", "Audi", 1850000m, 5, "Car", "2024" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType", "Color", "Condition", "Description", "FuelType", "Gearbox_Type", "KilometersDriven", "Model", "Motor_Capacity", "Name", "OwenerAddress", "OwenerEmail", "OwenerImage", "OwenerName", "OwenerPhonenumber", "Prand", "Price", "UsedCondition", "VehicleType", "Year" },
                values: new object[,]
                {
                    { 21, "Sedan", "Black", "Used", "Mercedes c180 2009\r\nEngine 1.6 L turbo . 156 hp\r\nMulti function \r\nCruise control\r\nDynamic select\r\npark assist\r\nFully sensors \r\nActive brake assist\r\nAttention assist\r\nFor reservations and inquiries contact us\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\nYou can buy it in cash or in installments with all banks and companies starting from 20%\r\nVisit our showroom to find your dream car", "Benzine", "Autohmatic", 220000, "C180", "1600 CC", "Mercedes-Benz C180 2009", null, null, null, null, null, "Mercedes", 1050000m, "Like New", "UsedCar", "2009" },
                    { 22, "SUV", "Black", "Used", "Mercedes G63 2022  AMG\r\nV8 \r\n577 HP\r\nAMG Speedshift TCT 9-speed transmission \r\nSmartKey with keylees-start\r\nElectric tailgate \r\nElectric seats\r\nShifting paddle \r\nBlind spot \r\nCamera 360\r\nSound system Burmester\r\nSunroof\r\nWireless apple carplay\r\nActive brake assist \r\nActive emergency stop Assist \r\nFully loaded \r\nالسياره بها جميع الكماليات\r\n‎متاح التقسيط مع جميع البنوك و الشركات بمقدم يبدا من ٢٠٪؜ حتي ٨٤ شهر", "Benzine", "Autohmatic", 15000, "G63", "4000 CC", "Mercedes-Benz G63 2022 AMG", null, null, null, null, null, "Mercedes-Benz", 7500000m, "Like New", "UsedCar", "2022" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CarType1", "Color", "Condition", "CreatedAt", "Description", "Car_Discount", "Car_Gearbox_Type", "Merchant_Logo", "Merchant_Name", "Merchant_Phone", "Model", "Car_Motor_Capacity", "Name", "Prand", "Price", "Car_Rate", "VehicleType", "Year" },
                values: new object[] { 23, "SUV", "blask", "New", null, "Audi Q3 sportback 2024\r\nExterior Color: Grey\r\nInterior: Black x red \r\nCondition: Brand New\r\nEngine: 1.5L\r\nHorse power:150 hp\r\n8-Speed Automatic Transmission\r\nAcceleration:0-100 km/h 9.2 sec\r\nLED Headlights\r\nElectrically Folding Exterior Mirrors\r\nFully Parking Sensors\r\nRim 19 inch\r\nSunroof\r\nElectric seats with memory package\r\nElectric tailgate\r\nWelcome lights\r\n360° Camera\r\n6 Airbags\r\n30-color Ambient Lighting\r\nVery special specs and color\r\nImmediate purchase\r\nFor reservations and inquiries contact us ", null, "Automatic", "/Images/TripixLogo.png", "Tripix", "01020652199", "CLE 200", "2000 CC", "Mercedes Cle 200 AMG 2024", "Mercedes-Benz", 1850000m, 5, "Car", "2024" });

            migrationBuilder.InsertData(
                table: "VehicleImages",
                columns: new[] { "Id", "DriverId", "DriverId1", "ImageUrl", "SparePartsId", "VehicleId" },
                values: new object[,]
                {
                    { 154, null, null, "/Images/BMW X6 M50i2017 1.WEBP", null, 17 },
                    { 155, null, null, "/Images/BMW X6 M50i2017 2.WEBP", null, 17 },
                    { 156, null, null, "/Images/BMW X6 M50i2017 3.WEBP", null, 17 },
                    { 157, null, null, "/Images/BMW X6 M50i2017 4.WEBP", null, 17 },
                    { 158, null, null, "/Images/BMW X6 M50i2017 5.WEBP", null, 17 },
                    { 159, null, null, "/Images/BMW X6 M50i2017 6.WEBP", null, 17 },
                    { 160, null, null, "/Images/BMW X6 M50i2017 7.WEBP", null, 17 },
                    { 161, null, null, "/Images/BMW X6 M50i2017 8.WEBP", null, 17 },
                    { 162, null, null, "/Images/BMW X6 M50i2017 9.WEBP", null, 17 },
                    { 163, null, null, "/Images/BMW X6 M50i2017 10.WEBP", null, 17 },
                    { 164, null, null, "/Images/Jaguar F-type 2021 mti 1.WEBP", null, 18 },
                    { 165, null, null, "/Images/Jaguar F-type 2021 mti 2.WEBP", null, 18 },
                    { 166, null, null, "/Images/Jaguar F-type 2021 mti 3.WEBP", null, 18 },
                    { 167, null, null, "/Images/Jaguar F-type 2021 mti 4.WEBP", null, 18 },
                    { 168, null, null, "/Images/Jaguar F-type 2021 mti 5.WEBP", null, 18 },
                    { 169, null, null, "/Images/Jaguar F-type 2021 mti 6.WEBP", null, 18 },
                    { 170, null, null, "/Images/Jaguar F-type 2021 mti 7.WEBP", null, 18 },
                    { 171, null, null, "/Images/Jaguar F-type 2021 mti 8.WEBP", null, 18 },
                    { 172, null, null, "/Images/Jaguar F-type 2021 mti 9.WEBP", null, 18 },
                    { 173, null, null, "/Images/Jaguar F-type 2021 mti 10.WEBP", null, 18 },
                    { 174, null, null, "/Images/BMW 750 Li 2009 1.WEBP", null, 19 },
                    { 175, null, null, "/Images/BMW 750 Li 2009 2.WEBP", null, 19 },
                    { 176, null, null, "/Images/BMW 750 Li 2009 3.WEBP", null, 19 },
                    { 177, null, null, "/Images/BMW 750 Li 2009 4.WEBP", null, 19 },
                    { 178, null, null, "/Images/BMW 750 Li 2009 5.WEBP", null, 19 },
                    { 179, null, null, "/Images/BMW 750 Li 2009 6.WEBP", null, 19 },
                    { 180, null, null, "/Images/BMW 750 Li 2009 7.WEBP", null, 19 },
                    { 181, null, null, "/Images/BMW 750 Li 2009 8.WEBP", null, 19 },
                    { 182, null, null, "/Images/BMW 750 Li 2009 9.WEBP", null, 19 },
                    { 183, null, null, "/Images/BMW 750 Li 2009 10.WEBP", null, 19 },
                    { 184, null, null, "/Images/Audi Q3 sportback 2024 1.WEBP", null, 20 },
                    { 185, null, null, "/Images/Audi Q3 sportback 2024 2.WEBP", null, 20 },
                    { 186, null, null, "/Images/Audi Q3 sportback 2024 3.WEBP", null, 20 },
                    { 187, null, null, "/Images/Audi Q3 sportback 2024 4.WEBP", null, 20 },
                    { 188, null, null, "/Images/Audi Q3 sportback 2024 5.WEBP", null, 20 },
                    { 189, null, null, "/Images/Audi Q3 sportback 2024 6.WEBP", null, 20 },
                    { 190, null, null, "/Images/Audi Q3 sportback 2024 7.WEBP", null, 20 },
                    { 191, null, null, "/Images/Audi Q3 sportback 2024 8.WEBP", null, 20 },
                    { 192, null, null, "/Images/Audi Q3 sportback 2024 9.WEBP", null, 20 },
                    { 193, null, null, "/Images/Audi Q3 sportback 2024 10.WEBP", null, 20 },
                    { 194, null, null, "/Images/Mercedes-Benz C180 2009 1.WEBP", null, 21 },
                    { 195, null, null, "/Images/Mercedes-Benz C180 2009 2.WEBP", null, 21 },
                    { 196, null, null, "/Images/Mercedes-Benz C180 2009 3.WEBP", null, 21 },
                    { 197, null, null, "/Images/Mercedes-Benz C180 2009 4.WEBP", null, 21 },
                    { 198, null, null, "/Images/Mercedes-Benz C180 2009 5.WEBP", null, 21 },
                    { 199, null, null, "/Images/Mercedes-Benz C180 2009 6.WEBP", null, 21 },
                    { 200, null, null, "/Images/Mercedes-Benz C180 2009 7.WEBP", null, 21 },
                    { 201, null, null, "/Images/Mercedes-Benz C180 2009 8.WEBP", null, 21 },
                    { 202, null, null, "/Images/Mercedes-Benz C180 2009 9.WEBP", null, 21 },
                    { 203, null, null, "/Images/Mercedes-Benz C180 2009 10.WEBP", null, 21 },
                    { 204, null, null, "/Images/Mercedes-Benz G63 2022 AMG 1.WEBP", null, 22 },
                    { 205, null, null, "/Images/Mercedes-Benz G63 2022 AMG 2.WEBP", null, 22 },
                    { 206, null, null, "/Images/Mercedes-Benz G63 2022 AMG 3.WEBP", null, 22 },
                    { 207, null, null, "/Images/Mercedes-Benz G63 2022 AMG 4.WEBP", null, 22 },
                    { 208, null, null, "/Images/Mercedes-Benz G63 2022 AMG 5.WEBP", null, 22 },
                    { 209, null, null, "/Images/Mercedes-Benz G63 2022 AMG 6.WEBP", null, 22 },
                    { 210, null, null, "/Images/Mercedes-Benz G63 2022 AMG 7.WEBP", null, 22 },
                    { 211, null, null, "/Images/Mercedes-Benz G63 2022 AMG 8.WEBP", null, 22 },
                    { 212, null, null, "/Images/Mercedes-Benz G63 2022 AMG 9.WEBP", null, 22 },
                    { 213, null, null, "/Images/Mercedes-Benz G63 2022 AMG 10.WEBP", null, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "VehicleImages",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "MaxID",
                table: "Trip");
        }
    }
}
