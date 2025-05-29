using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class UsedCarConfig : IEntityTypeConfiguration<UsedCar>
    {
        public void Configure ( EntityTypeBuilder<UsedCar> builder )
        {
            builder.Property(x => x.CarType)
                .HasConversion<string>();

            builder.Property(x => x.Gearbox_Type)
                .HasConversion<string>();

            builder.OwnsOne(x => x.CarLocation);




            builder.HasData(new List<UsedCar>
            {
                 new() {
                    Id = 7 ,
                    Name = "Porsche Taycan 2024",

                    KilometersDriven = 4000 ,
                    Year = "2024",
                    FuelType = "Electric",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "Taycan",
                    Color = "black",
                    Description = "Available now at 4Matic\r\nPorsche Taycan \r\nModel 2024\r\n4000 Km\r\nLicensed\r\nhas Protection \r\nRange 400-500",
                    Price = 6150000,
                    Prand = "Porsche",
                    CarType = CarTypes.Coupe,
                    Condition = "Used"
                 },
                 new() {
                    Id = 9 ,
                    Name = "Skoda Kodiaq 2024 Laurin & Klement",

                    KilometersDriven = 6500 ,
                    Year = "2024",
                    FuelType = "Benzine",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "Taycan",
                    Color = "White",
                    Description = "6500 km\r\nprotection\r\nlicensed\r\nlaurent & klement\r\ncamera 360\r\nالعنوان ٥٣ شارع عباس العقاد",
                    Price = 2850000,
                    Prand = "Skoda",
                    CarType = CarTypes.SUV,
                    Condition = "Used"
                 } ,
                  new() {
                    Id = 12 ,
                    Name = "Kia EV5 2024",

                    KilometersDriven = 15449 ,
                    Year = "2024",
                    FuelType = "Benzine",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "EV5",
                    Description = "السيارة الكهربائية بالكامل كيا Ev5 موديل ٢٠٢٤  متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : محرك كهربائي يولد 215 حصان ، فتحة سقف بانورامية ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة",
                    Price = 1690000,
                    Prand = "Kia",
                    CarType = CarTypes.SUV,
                    Condition = "Used"
                   },
                  new() {
                    Id = 13 ,
                    Name = "RANGE ROVE EVOQUE 2021",

                    KilometersDriven = 7000 ,
                    Year = "2021",
                    FuelType = "Benzine",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "Evoque",
                    Description = "\r\nرانج روفر ايفوك ٢٠٢١ SE عداد ٨ الف كيلو متوفرة الان في اكسدرايف اوتوموتيف\r\n\r\nالمواصفات : ١٥٠٠ سي سي توربو ١٦٠ حصان ، ليد داخلي متعدد الألوانة ، كاميرا ٣٦٠ درجة ، بصمة داخليه خارجيه ، كرسي كهرباء ، عدادات ديجتال ، مرايات ضم ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش ، سينسور بارك امامي خلفي \r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة",
                    Price = 3150000,
                    Prand = "Land Rover",
                    CarType = CarTypes.SUV,
                    Condition = "Used"
                   },
                  new() {
                    Id = 17 ,
                    Name = "BMW X6 M50i2017",

                    KilometersDriven = 170000 ,
                    Year = "2017",
                    FuelType = "Benzine",
                    Color = "Gray",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "X6",
                    Description = "BMW X6 M50i 2017\r\n4400cc\r\n523hp\r\nHarman/kardon sound system \r\nPanoramic sunroof \r\nHead-up display \r\nWireless Charger \r\nCamera 360 \r\nShifting paddles \r\nElectric seats with memory package \r\nFully loaded\r\nCheck our showroom to find your dream car. ",
                    Price = 3000000,
                    Prand = "BMW",
                    CarType = CarTypes.SUV,
                    Motor_Capacity = "4400 CC",
                    Condition = "Used"
                   },
                  new() {
                    Id = 18 ,
                    Name = "Jaguar F-type 2021 mti",

                    KilometersDriven = 30000 ,
                    Year = "2021",
                    FuelType = "Benzine",
                    Color = "Black",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "F-type",
                    Description = "Jaguar f-type 2021 mti \r\n30.000km\r\n2000cc\r\n300Hp\r\nTop speed 250km/h\r\nAcceleration 5.7 km/h (s)\r\nR-dynamic\r\nMeridian sound system \r\nElectric seats \r\nPanoramic sunroof \r\nShifting paddles \r\nApple carplay\r\nAndroid auto\r\nAmbient lighting \r\nWelcome lights \r\nFull active sensors\r\nNavigation\r\nAll Maintenance in mti \r\nFor reservations and inquiries contact us\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\nYou can buy it in cash or in installments with all banks and companies starting from 20% without ani admin fees \r\nVisit our showroom",
                    Price = 1500000,
                    Prand = "Jaguar",
                    CarType = CarTypes.Coupe,
                    Motor_Capacity = "2000 CC",
                    Condition = "Used"
                   },
                  new() {
                    Id = 19 ,
                    Name = "BMW 750 Li 2009",

                    KilometersDriven = 129000 ,
                    Year = "2009",
                    FuelType = "Benzine",
                    Color = "Black",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "750",
                    Description = "BMW 750 Li 2009\r\n\r\n•Engine: 4.4- liter twin turbo v8\r\n•Horse power: 400 hp\r\nspeech “ Hello BMW”\r\n•keyless entry \r\n•Panoramic sliding sunroof \r\n•fully sensors \r\n•Electric seats with memory package \r\n•Electric tailgate\r\n•Lane keep assist \r\n•Break assist \r\n•Soft close \r\n•Blind spot \r\n•Dual zone air conditions\r\n•Cruise control \r\n•fully loaded \r\n•Very special specs and color\r\nFor reservations and inquiries contact us ",
                    Price = 1400000,
                    Prand = "BMW",
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "4400 CC",
                    Condition = "Used"
                   },
                   new() {
                    Id = 21 ,
                    Name = "Mercedes-Benz C180 2009",

                    KilometersDriven = 220000 ,
                    Year = "2009",
                    FuelType = "Benzine",
                    Color = "Black",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "C180",
                    Description = "Mercedes c180 2009\r\nEngine 1.6 L turbo . 156 hp\r\nMulti function \r\nCruise control\r\nDynamic select\r\npark assist\r\nFully sensors \r\nActive brake assist\r\nAttention assist\r\nFor reservations and inquiries contact us\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\n(View phone number)\r\nYou can buy it in cash or in installments with all banks and companies starting from 20%\r\nVisit our showroom to find your dream car",
                    Price = 1050000,
                    Prand = "Mercedes",
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "1600 CC",
                    Condition = "Used"
                   },
                   new() {
                    Id = 22 ,
                    Name = "Mercedes-Benz G63 2022 AMG",

                    KilometersDriven = 15000 ,
                    Year = "2022",
                    FuelType = "Benzine",
                    Color = "Black",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Model = "G63",
                    Description = "Mercedes G63 2022  AMG\r\nV8 \r\n577 HP\r\nAMG Speedshift TCT 9-speed transmission \r\nSmartKey with keylees-start\r\nElectric tailgate \r\nElectric seats\r\nShifting paddle \r\nBlind spot \r\nCamera 360\r\nSound system Burmester\r\nSunroof\r\nWireless apple carplay\r\nActive brake assist \r\nActive emergency stop Assist \r\nFully loaded \r\nالسياره بها جميع الكماليات\r\n‎متاح التقسيط مع جميع البنوك و الشركات بمقدم يبدا من ٢٠٪؜ حتي ٨٤ شهر",
                    Price =  7500000,
                    Prand = "Mercedes-Benz",
                    CarType = CarTypes.SUV,
                    Motor_Capacity = "4000 CC",
                    Condition = "Used"
                   },
            });
        }
    }
}
