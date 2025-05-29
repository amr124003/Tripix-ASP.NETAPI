using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;



namespace Tripix.Context.Config
{
    public class ModelsConfig : IEntityTypeConfiguration<CarModel>
    {
        public void Configure ( EntityTypeBuilder<CarModel> builder )
        {
            builder.HasData(new List<CarModel>
             {
               // Toyota - BrandId = 1
              new() { Id = 1, BrandId = 1, Name = "Corolla", NameAR = "كورولا" },
              new() { Id = 2, BrandId = 1, Name = "Camry", NameAR = "كامري" },
              new() { Id = 3, BrandId = 1, Name = "Land Cruiser", NameAR = "لاند كروزر" },
              new() { Id = 4, BrandId = 1, Name = "Hilux", NameAR = "هايلوكس" },
              new() { Id = 5, BrandId = 1, Name = "Yaris", NameAR = "ياريس" },
              new() { Id = 6, BrandId = 1, Name = "Fortuner", NameAR = "فورتشنر" },
              new() { Id = 7, BrandId = 1, Name = "Highlander", NameAR = "هايلاندر" },
              
              // Hyundai - BrandId = 2
              new() { Id = 8, BrandId = 2, Name = "Verna", NameAR = "فيرنا" },
              new() { Id = 9, BrandId = 2, Name = "Excel", NameAR = "اكسل" },
              new() { Id = 10, BrandId = 2, Name = "Elantra", NameAR = "النترا" },
              new() { Id = 11, BrandId = 2, Name = "Tucson", NameAR = "توسان" },
              new() { Id = 12, BrandId = 2, Name = "Sonata", NameAR = "سوناتا" },
              new() { Id = 13, BrandId = 2, Name = "Palisade", NameAR = "باليسيد" },
              new() { Id = 14, BrandId = 2, Name = "Accent", NameAR = "اكسنت" },
              new() { Id = 15, BrandId = 2, Name = "Kona", NameAR = "كونا" },
              new() { Id = 16, BrandId = 2, Name = "Ioniq", NameAR = "ايونيك" },
              
              // Nissan - BrandId = 3
              new() { Id = 17, BrandId = 3, Name = "Altima", NameAR = "ألتيما" },
              new() { Id = 18, BrandId = 3, Name = "Maxima", NameAR = "ماكسيما" },
              new() { Id = 19, BrandId = 3, Name = "Patrol", NameAR = "باترول" },
              new() { Id = 20, BrandId = 3, Name = "Sentra", NameAR = "سينترا" },
              new() { Id = 21, BrandId = 3, Name = "X-Trail", NameAR = "إكس تريل" },
              new() { Id = 22, BrandId = 3, Name = "Juke", NameAR = "جوك" },
              new() { Id = 23, BrandId = 3, Name = "Rogue", NameAR = "روج" },
              
              // Kia - BrandId = 4
              new() { Id = 24, BrandId = 4, Name = "Sportage", NameAR = "سبورتاج" },
              new() { Id = 25, BrandId = 4, Name = "Cerato", NameAR = "سيراتو" },
              new() { Id = 26, BrandId = 4, Name = "Optima", NameAR = "أوبتيما" },
              new() { Id = 27, BrandId = 4, Name = "Seltos", NameAR = "سيلتوس" },
              new() { Id = 28, BrandId = 4, Name = "Stinger", NameAR = "ستينجر" },
              new() { Id = 29, BrandId = 4, Name = "Picanto", NameAR = "بيكانتو" },
              
              // Chevrolet - BrandId = 5
              new() { Id = 30, BrandId = 5, Name = "Optra", NameAR = "أوبترا" },
              new() { Id = 31, BrandId = 5, Name = "Aveo", NameAR = "أفيو" },
              new() { Id = 32, BrandId = 5, Name = "Malibu", NameAR = "ماليبو" },
              new() { Id = 33, BrandId = 5, Name = "Cruze", NameAR = "كروز" },
              new() { Id = 34, BrandId = 5, Name = "Tahoe", NameAR = "تاهو" },
              
              // Mercedes - BrandId = 6
              new() { Id = 35, BrandId = 6, Name = "C-Class", NameAR = "سي كلاس" },
              new() { Id = 36, BrandId = 6, Name = "E-Class", NameAR = "إي كلاس" },
              new() { Id = 37, BrandId = 6, Name = "S-Class", NameAR = "إس كلاس" },
              new() { Id = 38, BrandId = 6, Name = "GLE", NameAR = "جي إل إي" },
              new() { Id = 39, BrandId = 6, Name = "GLC", NameAR = "جي إل سي" },
              
              // BMW - BrandId = 7
              new() { Id = 40, BrandId = 7, Name = "X5", NameAR = "اكس 5" },
              new() { Id = 41, BrandId = 7, Name = "3 Series", NameAR = "السلسلة 3" },
              new() { Id = 42, BrandId = 7, Name = "7 Series", NameAR = "السلسلة 7" },
              new() { Id = 43, BrandId = 7, Name = "X3", NameAR = "اكس 3" },
              new() { Id = 44, BrandId = 7, Name = "M4", NameAR = "إم 4" },
              
              // Honda - BrandId = 8
              new() { Id = 45, BrandId = 8, Name = "Civic", NameAR = "سيفيك" },
              new() { Id = 46, BrandId = 8, Name = "Accord", NameAR = "أكورد" },
              new() { Id = 47, BrandId = 8, Name = "CR-V", NameAR = "سي آر في" },
              new() { Id = 48, BrandId = 8, Name = "Pilot", NameAR = "بايلوت" },
              new() { Id = 49, BrandId = 8, Name = "HR-V", NameAR = "إتش آر في" },
              new() { Id = 50, BrandId = 8, Name = "Jazz", NameAR = "جاز" },
              new() { Id = 51, BrandId = 8, Name = "Odyssey", NameAR = "أوديسي" },
              
              // Ford - BrandId = 9
              new() { Id = 52, BrandId = 9, Name = "Mustang", NameAR = "موستنج" },
              new() { Id = 53, BrandId = 9, Name = "F-150", NameAR = "إف 150" },
              new() { Id = 54, BrandId = 9, Name = "Explorer", NameAR = "إكسبلورر" },
              new() { Id = 55, BrandId = 9, Name = "Escape", NameAR = "إسكاب" },
              
              // Jeep - BrandId = 10
              new() { Id = 56, BrandId = 10, Name = "Cherokee", NameAR = "شيروكاي" },
              new() { Id = 57, BrandId = 10, Name = "Wrangler", NameAR = "رانجلر" },
              new() { Id = 58, BrandId = 10, Name = "Grand Cherokee", NameAR = "جراند شيروكي" },
              
              // Audi - BrandId = 11
              new() { Id = 59, BrandId = 11, Name = "A3", NameAR = "A3" },
              new() { Id = 60, BrandId = 11, Name = "A4", NameAR = "A4" },
              new() { Id = 61, BrandId = 11, Name = "Q7", NameAR = "Q7" },
              new() { Id = 62, BrandId = 11, Name = "Q5", NameAR = "Q5" },
              new() { Id = 63, BrandId = 11, Name = "A6", NameAR = "A6" },
              new() { Id = 64, BrandId = 11, Name = "Q8", NameAR = "Q8" },
              new() { Id = 65, BrandId = 11, Name = "RS7", NameAR = "RS7" },
              
              // Mazda - BrandId = 12
              new() { Id = 66, BrandId = 12, Name = "Mazda 3", NameAR = "مازدا 3" },
              new() { Id = 67, BrandId = 12, Name = "Mazda 6", NameAR = "مازدا 6" },
              new() { Id = 68, BrandId = 12, Name = "CX-5", NameAR = "CX-5" },
              new() { Id = 69, BrandId = 12, Name = "CX-9", NameAR = "CX-9" },
              new() { Id = 70, BrandId = 12, Name = "MX-5 Miata", NameAR = "MX-5 مياتا" },
              
              // Land Rover - BrandId = 13
              new() { Id = 71, BrandId = 13, Name = "Defender", NameAR = "ديفندر" },
              new() { Id = 72, BrandId = 13, Name = "Discovery", NameAR = "ديسكفري" },
              new() { Id = 73, BrandId = 13, Name = "Range Rover", NameAR = "رانج روفر" },
              new() { Id = 74, BrandId = 13, Name = "Evoque", NameAR = "إيفوك" },
              
              // Porsche - BrandId = 14
              new() { Id = 75, BrandId = 14, Name = "911", NameAR = "911" },
              new() { Id = 76, BrandId = 14, Name = "Cayenne", NameAR = "كاين" },
              new() { Id = 77, BrandId = 14, Name = "Macan", NameAR = "ماكان" },
              new() { Id = 78, BrandId = 14, Name = "Panamera", NameAR = "باناميرا" },
              new() { Id = 79, BrandId = 14, Name = "Taycan", NameAR = "تايكان" },
              
              // Lexus - BrandId = 15
              new() { Id = 80, BrandId = 15, Name = "RX", NameAR = "آر إكس" },
              new() { Id = 81, BrandId = 15, Name = "NX", NameAR = "إن إكس" },
              new() { Id = 82, BrandId = 15, Name = "IS", NameAR = "آي إس" },
              new() { Id = 83, BrandId = 15, Name = "LS", NameAR = "آل إس" },
              new() { Id = 84, BrandId = 15, Name = "LC", NameAR = "آل سي" },
              
              // Jaguar - BrandId = 16
              new() { Id = 85, BrandId = 16, Name = "F-Type", NameAR = "إف-تايب" },
              new() { Id = 86, BrandId = 16, Name = "XE", NameAR = "إكس إي" },
              new() { Id = 87, BrandId = 16, Name = "XF", NameAR = "إكس إف" },
              new() { Id = 88, BrandId = 16, Name = "F-Pace", NameAR = "إف-باس" },
              new() { Id = 89, BrandId = 16, Name = "I-Pace", NameAR = "آي-باس" },
              
              // Volvo - BrandId = 17
              new() { Id = 90, BrandId = 17, Name = "XC90", NameAR = "إكس سي 90" },
              new() { Id = 91, BrandId = 17, Name = "XC60", NameAR = "إكس سي 60" },
              new() { Id = 92, BrandId = 17, Name = "S90", NameAR = "إس 90" },
              new() { Id = 93, BrandId = 17, Name = "V90", NameAR = "في 90" },
              new() { Id = 94, BrandId = 17, Name = "S60", NameAR = "إس 60" },
              
              // Mitsubishi - BrandId = 18
              new() { Id = 95, BrandId = 18, Name = "Outlander", NameAR = "أوتلاندر" },
              new() { Id = 96, BrandId = 18, Name = "Lancer", NameAR = "لانسر" },
              new() { Id = 97, BrandId = 18, Name = "Pajero", NameAR = "بايجيرو" },
              new() { Id = 98, BrandId = 18, Name = "ASX", NameAR = "إيه إس إكس" },
              new() { Id = 99, BrandId = 18, Name = "Montero", NameAR = "مونتيرو" },
              
              // Subaru - BrandId = 19
              new() { Id = 100, BrandId = 19, Name = "Outback", NameAR = "أوتباك" },
              new() { Id = 101, BrandId = 19, Name = "Forester", NameAR = "فورستر" },
              new() { Id = 102, BrandId = 19, Name = "Impreza", NameAR = "إمبريزا" },
              new() { Id = 103, BrandId = 19, Name = "Legacy", NameAR = "ليغاسي" },
              new() { Id = 104, BrandId = 19, Name = "WRX", NameAR = "دبليو آر إكس" },
              
              // Peugeot - BrandId = 20
              new() { Id = 105, BrandId = 20, Name = "301", NameAR = "٣٠١" },
              new() { Id = 106, BrandId = 20, Name = "3008", NameAR = "٣٠٠٨" },
              new() { Id = 107, BrandId = 20, Name = "5008", NameAR = "٥٠٠٨" },
              new() { Id = 108, BrandId = 20, Name = "508", NameAR = "٥٠٨" },
              new() { Id = 109, BrandId = 20, Name = "206", NameAR = "٢٠٦" },
              new() { Id = 110, BrandId = 20, Name = "207", NameAR = "٢٠٧" },
              new() { Id = 111, BrandId = 20, Name = "208", NameAR = "٢٠٨" },
              new() { Id = 112, BrandId = 20, Name = "307", NameAR = "٣٠٧" },
              new() { Id = 113, BrandId = 20, Name = "308", NameAR = "٣٠٨" },
              new() { Id = 114, BrandId = 20, Name = "RCZ", NameAR = "آر سي زد" },
              
              // Renault - BrandId = 21
              new() { Id = 115, BrandId = 21, Name = "Logan", NameAR = "لوجان" },
              new() { Id = 116, BrandId = 21, Name = "Sandero", NameAR = "سانديرو" },
              new() { Id = 117, BrandId = 21, Name = "Stepway", NameAR = "ستيب واي" },
              new() { Id = 118, BrandId = 21, Name = "Megane", NameAR = "ميجان" },
              new() { Id = 119, BrandId = 21, Name = "Fluence", NameAR = "فلوانس" },
              new() { Id = 120, BrandId = 21, Name = "Duster", NameAR = "داستر" },
              new() { Id = 121, BrandId = 21, Name = "Koleos", NameAR = "كوليوس" },
              new() { Id = 122, BrandId = 21, Name = "Captur", NameAR = "كابتشر" },
              new() { Id = 123, BrandId = 21, Name = "Talisman", NameAR = "تاليسمان" },
              new() { Id = 124, BrandId = 21, Name = "Clio", NameAR = "كليو" },
              
              // Fiat - BrandId = 22
              new() { Id = 125, BrandId = 22, Name = "Tipo", NameAR = "تيبو" },
              new() { Id = 126, BrandId = 22, Name = "Punto", NameAR = "بونتو" },
              new() { Id = 127, BrandId = 22, Name = "500", NameAR = "٥٠٠" },
              new() { Id = 128, BrandId = 22, Name = "Bravo", NameAR = "برافو" },
              new() { Id = 129, BrandId = 22, Name = "Linea", NameAR = "لينيا" },
              new() { Id = 130, BrandId = 22, Name = "Doblo", NameAR = "دوبلو" },
              new() { Id = 131, BrandId = 22, Name = "Palio", NameAR = "باليـو" },
              new() { Id = 132, BrandId = 22, Name = "Siena", NameAR = "سيينا" },
              new() { Id = 133, BrandId = 22, Name = "Uno", NameAR = "أونو" },
              new() { Id = 134, BrandId = 22, Name = "124 Spider", NameAR = "١٢٤ سبايدر" },
              
              // Opel - BrandId = 23
              new() { Id = 135, BrandId = 23, Name = "Astra", NameAR = "أسترا" },
              new() { Id = 136, BrandId = 23, Name = "Corsa", NameAR = "كورسا" },
              new() { Id = 137, BrandId = 23, Name = "Insignia", NameAR = "إنسينييا" },
              new() { Id = 138, BrandId = 23, Name = "Mokka", NameAR = "موكا" },
              new() { Id = 139, BrandId = 23, Name = "Grandland", NameAR = "جراندلاند" },
              new() { Id = 140, BrandId = 23, Name = "Crossland", NameAR = "كروس لاند" },
              new() { Id = 141, BrandId = 23, Name = "Zafira", NameAR = "زافيرا" },
              new() { Id = 142, BrandId = 23, Name = "Vivaro", NameAR = "فيفارو" },
              new() { Id = 143, BrandId = 23, Name = "Adam", NameAR = "آدام" },
              new() { Id = 144, BrandId = 23, Name = "Meriva", NameAR = "مريفا" },
              new() { Id = 145, BrandId = 23, Name = "Astra Sports Tourer", NameAR = "أسترا سبورتس تورير" },
              
              // Seat - BrandId = 25
              new() { Id = 146, BrandId = 25, Name = "Ibiza", NameAR = "إيبيزا" },
              new() { Id = 147, BrandId = 25, Name = "Leon", NameAR = "ليون" },
              new() { Id = 148, BrandId = 25, Name = "Ateca", NameAR = "أتكا" },
              new() { Id = 149, BrandId = 25, Name = "Tarraco", NameAR = "تاراكو" },
              new() { Id = 150, BrandId = 25, Name = "Arona", NameAR = "أرونا" },
              new() { Id = 151, BrandId = 25, Name = "Alhambra", NameAR = "ألهامبرا" },
              new() { Id = 152, BrandId = 25, Name = "Toledo", NameAR = "توليدو" },
              new() { Id = 153, BrandId = 25, Name = "Cupra Born", NameAR = "كوبرا بورن" },
              
              // MG - BrandId = 26
              new() { Id = 154, BrandId = 26, Name = "ZS", NameAR = "زي إس" },
              new() { Id = 155, BrandId = 26, Name = "HS", NameAR = "إتش إس" },
              new() { Id = 156, BrandId = 26, Name = "MG3", NameAR = "إم جي ٣" },
              new() { Id = 157, BrandId = 26, Name = "MG5", NameAR = "إم جي ٥" },
              new() { Id = 158, BrandId = 26, Name = "MG6", NameAR = "إم جي ٦" },
              new() { Id = 159, BrandId = 26, Name = "MG Hector", NameAR = "إم جي هيكتور" },
              new() { Id = 160, BrandId = 26, Name = "MG ZS EV", NameAR = "إم جي زي إس إي في" },
              
              // Geely - BrandId = 27
              new() { Id = 161, BrandId = 27, Name = "Emgrand", NameAR = "إمجراند" },
              new() { Id = 162, BrandId = 27, Name = "Coolray", NameAR = "كولراي" },
              new() { Id = 163, BrandId = 27, Name = "Atlas", NameAR = "أطلس" },
              new() { Id = 164, BrandId = 27, Name = "Binyue", NameAR = "بينييو" },
              new() { Id = 165, BrandId = 27, Name = "Geely Xingyue", NameAR = "جيلي شينغيو" },
              new() { Id = 166, BrandId = 27, Name = "Geely Emgrand EV", NameAR = "جيلي إمجراند إي في" },
              
              // BYD - BrandId = 28
              new() { Id = 167, BrandId = 28, Name = "Tang", NameAR = "تانغ" },
              new() { Id = 168, BrandId = 28, Name = "Song", NameAR = "سونغ" },
              new() { Id = 169, BrandId = 28, Name = "Qin", NameAR = "تشين" },
              new() { Id = 170, BrandId = 28, Name = "F3", NameAR = "إف ٣" },
              new() { Id = 171, BrandId = 28, Name = "F5", NameAR = "إف ٥" },
              new() { Id = 172, BrandId = 28, Name = "E6", NameAR = "إي ٦" },
              new() { Id = 173, BrandId = 28, Name = "S7", NameAR = "إس ٧" },
              new() { Id = 174, BrandId = 28, Name = "BYD Yuan", NameAR = "بي واي دي يوان" },
              
              // JAC - BrandId = 29
              new() { Id = 175, BrandId = 29, Name = "J5", NameAR = "جي ٥" },
              new() { Id = 176, BrandId = 29, Name = "S3", NameAR = "إس ٣" },
              new() { Id = 177, BrandId = 29, Name = "JAC T6", NameAR = "جي إيه سي تي ٦" },
              new() { Id = 178, BrandId = 29, Name = "JAC S7", NameAR = "جي إيه سي إس ٧" },
              
              // Chery - BrandId = 30
              new() { Id = 179, BrandId = 30, Name = "Tiggo 2", NameAR = "تيغو ٢" },
              new() { Id = 180, BrandId = 30, Name = "Tiggo 3", NameAR = "تيغو ٣" },
              new() { Id = 181, BrandId = 30, Name = "Tiggo 4", NameAR = "تيغو ٤" },
              new() { Id = 182, BrandId = 30, Name = "Tiggo 5", NameAR = "تيغو ٥" },
              new() { Id = 183, BrandId = 30, Name = "Tiggo 7", NameAR = "تيغو ٧" },
              new() { Id = 184, BrandId = 30, Name = "Tiggo 8", NameAR = "تيغو ٨" },
              
              // Jetour - BrandId = 31
              new() { Id = 185, BrandId = 31, Name = "X70", NameAR = "إكس ٧٠" },
              new() { Id = 186, BrandId = 31, Name = "X90", NameAR = "إكس ٩٠" },
              new() { Id = 187, BrandId = 31, Name = "T1", NameAR = "تي ١" },
              new() { Id = 188, BrandId = 31, Name = "X95", NameAR = "إكس ٩٥" },
              new() { Id = 189, BrandId = 31, Name = "S1", NameAR = "إس ١" },
              new() { Id = 190, BrandId = 31, Name = "S5", NameAR = "إس ٥" },
              
              // Speranza - BrandId = 32
              new() { Id = 191, BrandId = 32, Name = "A516", NameAR = "إيه ٥١٦" },
              new() { Id = 192, BrandId = 32, Name = "M11", NameAR = "إم ١١" },
              new() { Id = 193, BrandId = 32, Name = "Speranza Tiggo", NameAR = "سبيرانزا تيغو" },
              new() { Id = 194, BrandId = 32, Name = "Tiggo 3", NameAR = "تيغو ٣" },
              new() { Id = 195, BrandId = 32, Name = "Tiggo 5", NameAR = "تيغو ٥" },
              
              // BAIC - BrandId = 33
              new() { Id = 196, BrandId = 33, Name = "X25", NameAR = "إكس ٢٥" },
              new() { Id = 197, BrandId = 33, Name = "X55", NameAR = "إكس ٥٥" },
              new() { Id = 198, BrandId = 33, Name = "BJ40", NameAR = "بي جي ٤٠" },
              new() { Id = 199, BrandId = 33, Name = "BJ80", NameAR = "بي جي ٨٠" },
              new() { Id = 200, BrandId = 33, Name = "J7", NameAR = "جي ٧" },
              new() { Id = 201, BrandId = 33, Name = "J3", NameAR = "جي ٣" },
              
              // Daewoo - BrandId = 34
              new() { Id = 202, BrandId = 34, Name = "Matiz", NameAR = "ماتيز" },
              new() { Id = 203, BrandId = 34, Name = "Lanos", NameAR = "لانوس" },
              new() { Id = 204, BrandId = 34, Name = "Nubira", NameAR = "نوبيرا" },
              new() { Id = 205, BrandId = 34, Name = "Espero", NameAR = "إسبيرو" },
              new() { Id = 206, BrandId = 34, Name = "Rezzo", NameAR = "ريزو" },
              new() { Id = 207, BrandId = 34, Name = "Kalos", NameAR = "كالوس" },
              
              // Dongfeng - BrandId = 35
              new() { Id = 208, BrandId = 35, Name = "DFM", NameAR = "دي إف إم" },
              new() { Id = 209, BrandId = 35, Name = "Rich", NameAR = "ريتش" },
              new() { Id = 210, BrandId = 35, Name = "H30", NameAR = "إتش ٣٠" },
              new() { Id = 211, BrandId = 35, Name = "DF4", NameAR = "دي إف ٤" },
              new() { Id = 212, BrandId = 35, Name = "DF5", NameAR = "دي إف ٥" },
              
              // DFSK - BrandId = 36
              new() { Id = 213, BrandId = 36, Name = "Mini Truck", NameAR = "ميني ترك" },
              new() { Id = 214, BrandId = 36, Name = "Glory", NameAR = "جلوري" },
              new() { Id = 215, BrandId = 36, Name = "Fengon", NameAR = "فينغون" },
              new() { Id = 216, BrandId = 36, Name = "C35", NameAR = "سي ٣٥" },
              
              // FAW - BrandId = 37
              new() { Id = 217, BrandId = 37, Name = "Besturn", NameAR = "بيسترن" },
              new() { Id = 218, BrandId = 37, Name = "Oley", NameAR = "أولي" },
              new() { Id = 219, BrandId = 37, Name = "Jiefang", NameAR = "جيفانغ" },
              
              // Foton - BrandId = 38
              new() { Id = 220, BrandId = 38, Name = "Auman", NameAR = "أومان" },
              new() { Id = 221, BrandId = 38, Name = "View", NameAR = "فيو" },
              new() { Id = 222, BrandId = 38, Name = "C1", NameAR = "سي ١" },
              new() { Id = 223, BrandId = 38, Name = "C2", NameAR = "سي ٢" },
              
              // Lifan - BrandId = 39
              new() { Id = 224, BrandId = 39, Name = "X60", NameAR = "إكس ٦٠" },
              new() { Id = 225, BrandId = 39, Name = "X50", NameAR = "إكس ٥٠" },
              new() { Id = 226, BrandId = 39, Name = "X70", NameAR = "إكس ٧٠" },
              
              // Proton - BrandId = 40
              new() { Id = 227, BrandId = 40, Name = "Saga", NameAR = "ساجا" },
              new() { Id = 228, BrandId = 40, Name = "Persona", NameAR = "بيرسونا" },
              new() { Id = 229, BrandId = 40, Name = "Exora", NameAR = "إكسورا" },
              new() { Id = 230, BrandId = 40, Name = "Iriz", NameAR = "إيريز" },
              new() { Id = 231, BrandId = 40, Name = "Preve", NameAR = "بريفي" },
              
              // Shalaby - BrandId = 41
              new() { Id = 232, BrandId = 41, Name = "Shalaby Pickup", NameAR = "شلبي بيك أب" },
              new() { Id = 233, BrandId = 41, Name = "Shalaby Truck", NameAR = "شلبي شاحنة" },
              new() { Id = 234, BrandId = 41, Name = "Shalaby Van", NameAR = "شلبي فان" },
              
              // Dayun - BrandId = 42
              new() { Id = 235, BrandId = 42, Name = "Dayun Truck", NameAR = "دايون شاحنة" },
              new() { Id = 236, BrandId = 42, Name = "Dayun Pickup", NameAR = "دايون بيك أب" },
              new() { Id = 237, BrandId = 42, Name = "Dayun Van", NameAR = "دايون فان" },
              
              // Volkswagen - BrandId = 43
              new() { Id = 238, BrandId = 43, Name = "Golf", NameAR = "جولف" },
              new() { Id = 239, BrandId = 43, Name = "Passat", NameAR = "باسات" },
              new() { Id = 240, BrandId = 43, Name = "Polo", NameAR = "بولو" },
              new() { Id = 241, BrandId = 43, Name = "Tiguan", NameAR = "تيجوان" },
              new() { Id = 242, BrandId = 43, Name = "Jetta", NameAR = "جيتا" },
              new() { Id = 243, BrandId = 43, Name = "Arteon", NameAR = "أرتيون" },
              new() { Id = 244, BrandId = 43, Name = "Touareg", NameAR = "توارغ" },
              new() { Id = 245, BrandId = 43, Name = "ID.4", NameAR = "آي دي ٤" },
              new() { Id = 246, BrandId = 43, Name = "Beetle", NameAR = "بيتل" },
              
              // Skoda - BrandId 44
              new() { Id = 247, BrandId = 44, Name = "Octavia", NameAR = "أوكتافيا" },
              new() { Id = 248, BrandId = 44, Name = "Superb", NameAR = "سوبرب" },
              new() { Id = 249, BrandId = 44, Name = "Karoq", NameAR = "كاروق" },
              new() { Id = 250, BrandId = 44, Name = "Kodiaq", NameAR = "كودياك" },
              new() { Id = 251, BrandId = 44, Name = "Fabia", NameAR = "فابيا" },
              new() { Id = 252, BrandId = 44, Name = "Scala", NameAR = "سكالا" },
              new() { Id = 253, BrandId = 44, Name = "Kamiq", NameAR = "كامييك" },
               // Tesla (BrandId = 45)
              new() { Id = 254, BrandId = 45, Name = "Model S", NameAR = "موديل S" },
              new() { Id = 255, BrandId = 45, Name = "Model 3", NameAR = "موديل 3" },
              new() { Id = 256, BrandId = 45, Name = "Model X", NameAR = "موديل X" },
              new() { Id = 257, BrandId = 45, Name = "Model Y", NameAR = "موديل Y" },
              new() { Id = 258, BrandId = 45, Name = "Cybertruck", NameAR = "سايبر تراك" },
              new() { Id = 259, BrandId = 45, Name = "Roadster", NameAR = "رودستر" },
              
              // Fisker (BrandId = 46)
              new() { Id = 260, BrandId = 46, Name = "Ocean", NameAR = "أوشن" },
              new() { Id = 261, BrandId = 46, Name = "PEAR", NameAR = "بير" },
              
              // Aito (BrandId = 47)
              new() { Id = 262, BrandId = 47, Name = "M5", NameAR = "أيتو M5" },
              new() { Id = 263, BrandId = 47, Name = "M7", NameAR = "أيتو M7" },
              
              // Weltmeister (BrandId = 48)
              new() { Id = 264, BrandId = 48, Name = "EX5", NameAR = "إي إكس 5" },
              new() { Id = 265, BrandId = 48, Name = "W6", NameAR = "دبليو 6" },
              new() { Id = 266, BrandId = 48, Name = "E5", NameAR = "إي 5" },
              
              // Aiways (BrandId = 49)
              new() { Id = 267, BrandId = 49, Name = "U5", NameAR = "يو 5" },
              new() { Id = 268, BrandId = 49, Name = "U7", NameAR = "يو 7" },
              
              // BYD Electric (BrandId = 50)
              new() { Id = 269, BrandId = 50, Name = "Han EV", NameAR = "هان إي في" },
              new() { Id = 270, BrandId = 50, Name = "Tang EV", NameAR = "تانغ إي في" },
              new() { Id = 271, BrandId = 50, Name = "Song Plus EV", NameAR = "سونغ بلس إي في" },
              new() { Id = 272, BrandId = 50, Name = "Dolphin", NameAR = "دولفين" },
              new() { Id = 273, BrandId = 50, Name = "Seal", NameAR = "سيل" },
              new() { Id = 274, BrandId = 50, Name = "Atto 3", NameAR = "آتو 3" },
              new() { Id = 275, BrandId = 50, Name = "Qin Plus EV", NameAR = "تشين بلس إي في" },
              // Harley-Davidson - BrandId = 54
              new() { Id = 276, BrandId = 54, Name = "Street 750", NameAR = "ستريت 750" },
              new() { Id = 277, BrandId = 54, Name = "Iron 883", NameAR = "آيرون 883" },
              new() { Id = 278, BrandId = 54, Name = "Fat Bob", NameAR = "فات بوب" },
              new() { Id = 279, BrandId = 54, Name = "Sportster S", NameAR = "سبورتستر S" },
              
              // Yamaha - BrandId = 55
              new() { Id = 280, BrandId = 55, Name = "YZF-R1", NameAR = "واي زد إف R1" },
              new() { Id = 281, BrandId = 55, Name = "MT-07", NameAR = "إم تي 07" },
              new() { Id = 282, BrandId = 55, Name = "NMAX", NameAR = "إن ماكس" },
              new() { Id = 283, BrandId = 55, Name = "FZ25", NameAR = "إف زد 25" },
              
              // Honda - BrandId = 56
              new() { Id = 284, BrandId = 56, Name = "CBR500R", NameAR = "سي بي آر 500 آر" },
              new() { Id = 285, BrandId = 56, Name = "CB650R", NameAR = "سي بي 650 آر" },
              new() { Id = 286, BrandId = 56, Name = "Rebel 500", NameAR = "ريبل 500" },
              new() { Id = 287, BrandId = 56, Name = "Africa Twin", NameAR = "أفريكا توين" },
              
              // BMW Motorrad - BrandId = 57
              new() { Id = 288, BrandId = 57, Name = "R1250GS", NameAR = "آر 1250 جي إس" },
              new() { Id = 289, BrandId = 57, Name = "G310R", NameAR = "جي 310 آر" },
              new() { Id = 290, BrandId = 57, Name = "F900R", NameAR = "إف 900 آر" },
              
              // KTM - BrandId = 58
              new() { Id = 291, BrandId = 58, Name = "Duke 390", NameAR = "ديوك 390" },
              new() { Id = 292, BrandId = 58, Name = "RC 200", NameAR = "آر سي 200" },
              new() { Id = 293, BrandId = 58, Name = "1290 Super Duke R", NameAR = "1290 سوبر ديوك آر" },
              
              // Ducati - BrandId = 59
              new() { Id = 294, BrandId = 59, Name = "Panigale V4", NameAR = "بانيجالي V4" },
              new() { Id = 295, BrandId = 59, Name = "Monster 937", NameAR = "مونستر 937" },
              new() { Id = 296, BrandId = 59, Name = "Multistrada V4", NameAR = "مولتسترادا V4" },
              
              // Bajaj - BrandId = 60
              new() { Id = 297, BrandId = 60, Name = "Pulsar 220F", NameAR = "بولسار 220 إف" },
              new() { Id = 298, BrandId = 60, Name = "Dominar 400", NameAR = "دومينار 400" },
              new() { Id = 299, BrandId = 60, Name = "Platina", NameAR = "بلاتينا" },
              
              // TVS - BrandId = 61
              new() { Id = 300, BrandId = 61, Name = "Apache RTR 160", NameAR = "أباتشي RTR 160" },
              new() { Id = 301, BrandId = 61, Name = "NTorq 125", NameAR = "إن تورك 125" },
              new() { Id = 302, BrandId = 61, Name = "Raider 125", NameAR = "رايدر 125" },
              // Bajaj
              new() { Id = 344, BrandId = 62, Name = "Pulsar 150", NameAR = "بولسار 150" },
              new() { Id = 345, BrandId = 62, Name = "Boxer X125", NameAR = "بوكسر X125" },
              new() { Id = 346, BrandId = 62, Name = "Discover 125", NameAR = "ديسكفر 125" },
              new() { Id = 347, BrandId = 62, Name = "Avenger Street 160", NameAR = "أفنجر ستريت 160" },
              
              // Hero
              new() { Id = 348, BrandId = 63, Name = "Splendor Plus", NameAR = "سبليندر بلس" },
              new() { Id = 349, BrandId = 63, Name = "HF Deluxe", NameAR = "إتش إف ديلوكس" },
              new() { Id = 350, BrandId = 63, Name = "Glamour", NameAR = "غلامور" },
              new() { Id = 351, BrandId = 63, Name = "Xtreme 160R", NameAR = "إكستريم 160R" },
              
              // TVS
              new() { Id = 352, BrandId = 64, Name = "Apache RTR 160", NameAR = "أباتشي RTR 160" },
              new() { Id = 353, BrandId = 64, Name = "Star City Plus", NameAR = "ستار سيتي بلس" },
              new() { Id = 354, BrandId = 64, Name = "Sport", NameAR = "سبورت" },
              new() { Id = 355, BrandId = 64, Name = "NTorq 125", NameAR = "إن تورك 125" },
              
              // Royal Enfield
              new() { Id = 356, BrandId = 65, Name = "Classic 350", NameAR = "كلاسيك 350" },
              new() { Id = 357, BrandId = 65, Name = "Bullet 350", NameAR = "بُلت 350" },
              new() { Id = 358, BrandId = 65, Name = "Meteor 350", NameAR = "ميتيور 350" },
              new() { Id = 359, BrandId = 65, Name = "Himalayan", NameAR = "هيماﻻيان" },
              
              // Aprilia
              new() { Id = 360, BrandId = 66, Name = "SR 160", NameAR = "إس آر 160" },
              new() { Id = 361, BrandId = 66, Name = "RS 660", NameAR = "آر إس 660" },
              new() { Id = 362, BrandId = 66, Name = "Tuono 660", NameAR = "تونو 660" },
              
              // Benelli
              new() { Id = 363, BrandId = 67, Name = "TNT 135", NameAR = "تي إن تي 135" },
              new() { Id = 364, BrandId = 67, Name = "502C", NameAR = "502 سي" },
              new() { Id = 365, BrandId = 67, Name = "Imperiale 400", NameAR = "إمبريالي 400" },
              
              // CFMoto
              new() { Id = 366, BrandId = 68, Name = "300NK", NameAR = "300 إن كيه" },
              new() { Id = 367, BrandId = 68, Name = "650NK", NameAR = "650 إن كيه" },
              new() { Id = 368, BrandId = 68, Name = "250SR", NameAR = "250 إس آر" },
              
              // Vespa
              new() { Id = 369, BrandId = 69, Name = "Primavera 150", NameAR = "بريمافيرا 150" },
              new() { Id = 370, BrandId = 69, Name = "Sprint 150", NameAR = "سبرينت 150" },
              new() { Id = 371, BrandId = 69, Name = "GTS Super 300", NameAR = "جي تي إس سوبر 300" },
              
              // SYM
              new() { Id = 372, BrandId = 70, Name = "Jet 14", NameAR = "جيت 14" },
              new() { Id = 373, BrandId = 70, Name = "Symphony ST", NameAR = "سيمفوني إس تي" },
              new() { Id = 374, BrandId = 70, Name = "Cruisym 300", NameAR = "كروزيم 300" },

              new() { Id = 303, BrandId = 71, Name = "KPR 150", NameAR = "كي بي آر 150" },
              new() { Id = 304, BrandId = 71, Name = "KPR 200", NameAR = "كي بي آر 200" },
              new() { Id = 305, BrandId = 71, Name = "KP Mini 110", NameAR = "كي بي ميني 110" },
              new() { Id = 306, BrandId = 71, Name = "LF150-10", NameAR = "إل إف 150-10" },
              new() { Id = 307, BrandId = 71, Name = "LF200-23", NameAR = "إل إف 200-23" },
              new() { Id = 308, BrandId = 72, Name = "Zontes 310R", NameAR = "زونتس 310 آر" },
              new() { Id = 309, BrandId = 72, Name = "Zontes 310X", NameAR = "زونتس 310 إكس" },
              new() { Id = 310, BrandId = 72, Name = "Zontes 250", NameAR = "زونتس 250" },
              new() { Id = 311, BrandId = 72, Name = "Zontes 125-U", NameAR = "زونتس 125-يو" },
              // Nissan
              new() { Id = 312, BrandId = 73, Name = "Leaf S", NameAR = "ليف إس" },
              new() { Id = 313, BrandId = 73, Name = "Leaf SV", NameAR = "ليف إس في" },
              new() { Id = 314, BrandId = 73, Name = "Altima", NameAR = "ألتيما" },
              new() { Id = 315, BrandId = 73, Name = "Rogue", NameAR = "روغ" },
              
              // Chevrolet
              new() { Id = 316, BrandId = 74, Name = "Bolt EV", NameAR = "بولت إي في" },
              new() { Id = 317, BrandId = 74, Name = "Bolt EUV", NameAR = "بولت إيوي" },
              new() { Id = 318, BrandId = 74, Name = "Malibu", NameAR = "ماليبو" },
              new() { Id = 319, BrandId = 74, Name = "Tahoe", NameAR = "تاهو" },
              
              // BMW
              new() { Id = 320, BrandId = 75, Name = "i3", NameAR = "آي 3" },
              new() { Id = 321, BrandId = 75, Name = "iX", NameAR = "آي إكس" },
              new() { Id = 322, BrandId = 75, Name = "X5", NameAR = "إكس 5" },
              new() { Id = 323, BrandId = 75, Name = "3 Series", NameAR = "3 سيريز" },
              
              // Audi
              new() { Id = 324, BrandId = 76, Name = "e-tron", NameAR = "إي ترون" },
              new() { Id = 325, BrandId = 76, Name = "e-tron GT", NameAR = "إي ترون جي تي" },
              new() { Id = 326, BrandId = 76, Name = "Q5", NameAR = "كيو 5" },
              new() { Id = 327, BrandId = 76, Name = "A4", NameAR = "إيه 4" },
              
              // Jaguar
              new() { Id = 328, BrandId = 77, Name = "I-Pace", NameAR = "آي-بيس" },
              new() { Id = 329, BrandId = 77, Name = "XF", NameAR = "إكس إف" },
              
              // Rivian
              new() { Id = 330, BrandId = 78, Name = "R1T", NameAR = "آر1 تي" },
              new() { Id = 331, BrandId = 78, Name = "R1S", NameAR = "آر1 إس" },
              
              // Lucid Motors
              new() { Id = 332, BrandId = 79, Name = "Air", NameAR = "آير" },
              
              // NIO
              new() { Id = 333, BrandId = 80, Name = "ES8", NameAR = "إي إس8" },
              new() { Id = 334, BrandId = 80, Name = "ES6", NameAR = "إي إس6" },
              
              // XPeng
              new() { Id = 335, BrandId = 81, Name = "P7", NameAR = "بي7" },
              new() { Id = 336, BrandId = 81, Name = "G3", NameAR = "جي3" },
              
              // Polestar
              new() { Id = 337, BrandId = 82, Name = "Polestar 2", NameAR = "بولستار 2" },
              
              // Faraday Future
              new() { Id = 338, BrandId = 83, Name = "FF 91", NameAR = "إف إف 91" },
              
              // Tesla
              new() { Id = 339, BrandId = 84, Name = "Model S", NameAR = "موديل إس" },
              new() { Id = 340, BrandId = 84, Name = "Model 3", NameAR = "موديل 3" },
              new() { Id = 341, BrandId = 84, Name = "Model X", NameAR = "موديل إكس" },
              new() { Id = 342, BrandId = 84, Name = "Model Y", NameAR = "موديل واي" },
              
              // VinFast
              new() { Id = 343, BrandId = 85, Name = "VF e34", NameAR = "في إف إي 34" }




            });

        }
    }
}
