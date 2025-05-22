using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure ( EntityTypeBuilder<Car> builder )
        {
            builder.Property(x => x.CarType)
                .HasConversion<string>();

            builder.Property(x => x.Gearbox_Type)
                .HasConversion<string>();




            builder.HasData(new List<Car>
            {
                 new() {
                     Id = 1,
                    Name = "Mercedes-Benz",
                    Year = "2025",
                    Model = "E200",
                    Color = "black",
                    Description = "E200 2025 \r\nAmg Premium Plus\r\nsoft close\r\nkeyless entry\r\nkeyless start\r\nelectric seats\r\nmemory seats\r\nheated seats\r\nheadup display\r\nfourzone ac\r\ncamera 360\r\nblind spot\r\nnight package\r\nblack rims\r\nfor more info call us at (View phone number)\r\nor visit us at 53 Abbas el Akkad",
                    Price = 5550000,
                    Prand = "Mercedes",
                    Motor_Capacity = "2000 CC",
                    Condition = "New",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Rate = 5,
                    CarType = CarTypes.Sedan
                },
                 new() {
                     Id = 2,
                    Name = "MERCEDES MAYBACH",
                    Year = "2024",
                    Model = "S-580",
                    Color = "Gray",
                    Description = "MERCEDES MAYBACH S-560 4MATIC 2024\r\n\r\nبأقل سعر فى مصر\r\nاسعارخاصه للعملاء الكاش\r\nمتاح انظمه تقسيط بدون حظر بيع و بدون م اداريه و بدون تأمين\r\nعروض خاصه و حصريه لرجال الاعمال بسجل تجارى و بطاقه ضريبيه تحصل على مقدم يبدأ من 5% و تقسيط لمده 10 سنوات\r\n\r\nمتاح استبدال سيارتك القديمه\r\nمتاح ايضا لدينا اكثر من 30 برنامج للتقسيط ل ربات البيوت والموظفين و الاطباء والظباط\r\n\r\n Available all colors, Models and Categories \r\nالاسعار تختلف حسب الفئه و الموديل\r\n   ",
                    Price = 24000000,
                    Prand = "Mercedes",
                    Motor_Capacity = "4000 CC",
                    Condition = "New",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Rate = 5,
                    CarType = CarTypes.Sedan,
                    Merchant_Name = "Teacher Motors",
                    Merchant_Phone = "0114585330",
                    Merchant_Logo = "/Images/Teacher Motors.WEBP"
                 },
                  new() {
                      Id = 3,
                    Name = "Toyota Corolla 2025",
                    Year = "2025",
                    Model = "Corolla",
                    Color = "White",
                    Description = "Toyota corolla \r\nModel 2025\r\nالفئة الثالثة\r\nor visit us at 53 Abbas El Akkad, Nasr city",
                    Price = 1600000,
                    Prand = "Toyota",
                    Motor_Capacity = "1600 CC",
                    Condition = "New",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Rate = 5,
                    CarType = CarTypes.Sedan
                 },
                  new() {
                      Id = 4,
                    Name = "Mercedes-Benz GLC 300",
                    Year = "2025",
                    Model = "GLC 300",
                    Color = "White",
                    Description = "Glc 300 \r\nModel 2025\r\nhydraulic suspension\r\nrear axle\r\nHeadup display\r\nfourzone\r\ncamera360\r\nburmester speakers \r\nblind spot\r\nelectric seats\r\nmemory seats\r\nheater seats\r\nkeyless entry\r\nside doorstep\r\nfeather rims",
                    Price = 6250000,
                    Prand = "Mercedes",
                    Motor_Capacity = "2000 CC",
                    Condition = "New",
                    Gearbox_Type = GearboxTypes.Automatic,
                    Rate = 5,
                    CarType = CarTypes.Coupe
                  },
                     new() {
                    Id = 5,
                    Name = "Mercedes Benz E200",
                    Year = "2024",
                    Model = "E200",
                    Color = "black",
                    Description = "E200 \r\nmodel 2024 \r\nzero\r\nfully loaded \r\nnight package",
                    Price = 5375000,
                    Prand = "Mercedes",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "2000 CC",
                    Gearbox_Type = GearboxTypes.Automatic
                     },
                    new() {
                    Id = 8,
                    Name = "Range Rover Velar 2025",
                    Year = "2025",
                    Model = "Velar",
                    Color = "black",
                    Description = "Range Rover Velar R-daynamic\r\n- Model 2025\r\n- ⁠Zero\r\n- فيها رخصه ٣ سنين\r\n- ⁠10 years warranty Protection\r\n- Engine : 2.0 liter\r\n- 250 HP\r\n- ⁠Exterior Color : Black \r\n- Interior Color : Beig leather\r\n- Apple Carplay & Android Auto\r\n- Slide Panoramic Sunroof\r\n- Meredian Sound system\r\n- Blind spot\r\n- Lane assist\r\n- Adaptive Control\r\n- 2 electric seats with memory \r\n- Head up Display\r\n- Air suspention\r\n- Ambient light system\r\n- electric trunk\r\n- Keyless Go\r\n- Front and rear sensor park\r\n- 360 camera\r\n- Heated seats\r\n- Automatic AC control\r\n- 20 inch Black allow wheel",
                    Price = 6350000,
                    Prand = "Land Rover",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "2000 CC",
                    Gearbox_Type = GearboxTypes.Automatic
                     },
                    new() {
                    Id = 10,
                    Name = "Porsche Macan 2024",
                    Year = "2024",
                    Model = "Macan",
                    Color = "black",
                    Description = "Porsche Macan\r\nبورش ماكان\r\n\r\nModel 2024 (wakeel)\r\nموديل 2024 (وكيل)\r\n\r\nPre owned 17,000KM\r\nمستعملة بممشى 17,000 كم\r\n\r\nExterior: Metallic Black\r\nاللون الخارجي: أسود ميتاليك\r\n\r\nInterior: Red leather\r\nاللون الداخلي: جلد أحمر\r\n\r\nEngine type: turbocharged\r\nنوع المحرك: تيربو\r\n\r\n2L straight 4 cylinders\r\n2 لتر، 4 سلندر خطي\r\n\r\nHorsepower: 261 hp\r\nقوة المحرك: 261 حصان\r\n\r\nMax. torque 295 lb-ft\r\nأقصى عزم: 295 رطل/قدم\r\n\r\n0 - 60 mph in 5.8 seconds with Sport Chrono Package\r\nمن 0 إلى 60 ميل في الساعة في 5.8 ثانية مع باكيدج سبورت كرونو\r\n\r\nTransmission: 7-speed twin-clutch auto (PDK)\r\nناقل حركة أوتوماتيك 7 سرعات (PDK) ثنائي القابض\r\n\r\nAll wheel drive\r\nدفع كلي\r\n\r\nPanoramic sunroof\r\nفتحة سقف بانورامية\r\n\r\nRims: R20 multi spoke\r\nجنوط R20 متعددة الأذرع\r\n\r\n360 parking cameras\r\nكاميرات ركن 360 درجة\r\n\r\nBoss sound system\r\nنظام صوتي من Bose\r\n\r\nThe LED headlights including Porsche Dynamic Light System (PDLS)\r\nكشافات LED تشمل نظام الإضاءة الديناميكي من بورش (PDLS)\r\n\r\nKeyless entry and start/stop\r\nدخول وتشغيل بدون مفتاح\r\n\r\n8-way Front Sport Seats\r\nمقاعد أمامية رياضية بـ 8 وضعيات\r\n\r\nSeat heating\r\nتدفئة للمقاعد\r\n\r\nPorsche logo on seats\r\nشعار بورش على المقاعد\r\n\r\nPorsche word illuminate as welcome\r\nإضاءة كلمة Porsche عند الترحيب\r\n\r\nElectric tailgate\r\nباب شنطة خلفية كهربائي\r\n\r\nApple CarPlay\r\nابل كار بلاي\r\n\r\nAndroid Auto\r\nأندرويد أوتو\r\n\r\nWireless phone charger\r\nشاحن لاسلكي للهاتف\r\n\r\nNavigation system\r\nنظام ملاحة\r\n\r\nSport space tires\r\nكفرات سبور سبيس\r\n\r\nPrivacy glass\r\nزجاج فاميـه (خصوصي)\r\n\r\nLarge brake system with black paint callipers\r\nنظام فرامل كبير مع كاليبرات باللون الأسود\r\n\r\nElectronic brake distribution\r\nتوزيع إلكتروني لقوة الفرامل",
                    Price = 4850000,
                    Prand = "Porsche",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "2000 CC",
                    Gearbox_Type = GearboxTypes.Automatic
                     },
                    new() {
                    Id = 11,
                    Name = "Hyundai Elantra 2025",
                    Year = "2025",
                    Model = "Elantra",
                    Color = "White",
                    Description = "هونداي الينترا cn7 اعلى فئة  ٢٠٢٥ متوفرة الان في اكسدرايف اوتوموتيف\r\n\r\n\r\n\r\nالمواصفات : بصمة داخليه خارجيه ، فتحة سقف ، عدادات ديجتال ، فرش جلد ، تحديد مسار ، تسخين كراسي ، تسخين مقود ، جنوط ١٧ لونين ، مرايات ضم ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش ، سينسور بارك امامي خلفي \r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة\r\n\r\n لمزيد من التفاصيل يرجى التواصل على الارقام التالية",
                    Price = 1550000,
                    Prand = "Hyundai",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.Sedan,
                    Motor_Capacity = "1500 CC",
                    Gearbox_Type = GearboxTypes.Automatic,
                     },
                    new() {
                    Id = 14,
                    Name = "MG RX5 2024",
                    Year = "2024",
                    Model = "RX5",
                    Color = "Gray",
                    Description = "هونداي الينتراMG RX5 2024 Luxury  متوفرة الان في اكسدرايف اوتوموتيف \r\n\r\n\r\n\r\nالمواصفات : ١. ٥٠٠ سي سي توربو ، بصمة داخليه خارجيه ، فتحة سقف بانوراما ، تكييف ديجتال ، فرش جلد، جنوط١٨ ، مرايات ضم ، شاحن وايرلس ، ليدات امامي خلفي ، مثبت سرعة ، شاشة تاتش تدعم apple carplay و android auto ، سينسور بارك امامي خلفي ، كاميرات محيطية ٣٦٠ درجة\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة",
                    Price = 1450000,
                    Prand = "MG",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.SUV,
                    Motor_Capacity = "1500 CC",
                    Gearbox_Type = GearboxTypes.Automatic,
                     },
                    new() {
                    Id = 15,
                    Name = "Audi Q4 E-Tron 2024",
                    Year = "2024",
                    Model = "Q4 E-Tron",
                    Description = "هونداي الينتراالسيارة الكهربائية بالكامل اودي Q4 e-tron موديل 2024 متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : 40e-tron ، محرك كهربائي يولد ٢٣٠ حصان ، ٧ راكب ، فتحة سقف بانورامية متحركة ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، شاشة عرض على الزجاج الامامي HUD ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة",
                    Price = 2390000,
                    Prand = "Audi",
                    Condition = "New",
                    Rate = 5,
                    CarType = CarTypes.SUV,
                    Motor_Capacity = "1500 CC",
                    Gearbox_Type = GearboxTypes.Automatic,
                     },
                    new() {
                    Id = 20,
                    Name = "Audi Q3 sportback 2024",
                    Year = "2024",
                    Model = "Q3",
                    Description = "Audi Q3 sportback 2024\r\nExterior Color: Grey\r\nInterior: Black x red \r\nCondition: Brand New\r\nEngine: 1.5L\r\nHorse power:150 hp\r\n8-Speed Automatic Transmission\r\nAcceleration:0-100 km/h 9.2 sec\r\nLED Headlights\r\nElectrically Folding Exterior Mirrors\r\nFully Parking Sensors\r\nRim 19 inch\r\nSunroof\r\nElectric seats with memory package\r\nElectric tailgate\r\nWelcome lights\r\n360° Camera\r\n6 Airbags\r\n30-color Ambient Lighting\r\nVery special specs and color\r\nImmediate purchase\r\nFor reservations and inquiries contact us ",
                    Price = 1850000,
                    Prand = "Audi",
                    Condition = "New",
                    Rate = 5,
                    Color = "Gray",
                    CarType = CarTypes.SUV,
                    Motor_Capacity = "1500 CC",
                    Gearbox_Type = GearboxTypes.Automatic,
                     },
            });
        }
    }
}
