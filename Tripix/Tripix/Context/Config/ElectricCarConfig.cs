using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class ElectricCarConfig : IEntityTypeConfiguration<ElectricCars>
    {
        public void Configure ( EntityTypeBuilder<ElectricCars> builder )
        {
            builder.Property(x => x.CarType)
                .HasConversion<string>();



            builder.HasData(new List<ElectricCars>
            {
                  new() {
                    Id = 6 ,
                    Name = "Volkswagen ID6 Crozz Pro",
                    TravelRange = 601,
                    Year = "2024",
                    Model = "ID6 Crozz Pro",
                    Color = "black",
                    Description = "Id6 crozz pro 2024 \r\nEnergy type: Pure electric \r\nRange: 601\r\nMax speed: 160\r\nCamera 360\r\nBlind spot\r\nHeadup display",
                    Price = 2350000,
                    Prand = "Volkswagen",

                    Rate = 5,
                    CarType = CarTypes.SUV
                  } ,

                    new() {
                    Id = 16 ,
                    Name = "Changan S7 FULL ELECTRIC 2024",
                    Power = 258 ,
                    Year = "2024",
                    Model = "V7",
                    Color = "White",
                    Interior = "Full Leather" ,
                    Description = "السيارة الكهربائية بالكامل شانجان S7 موديل ٢٠٢٤  متوفرة الآن في اكسدرايف اوتوموتيف   \r\n\r\nالمواصفات : محرك كهربائي يولد ٢٥٨ حصان ، فتحة سقف بانورامية ، مساج كراسي , كراسي كهرباء ، بصمة داخلية و خارجية ، شنطة كهرباء ، شاشة عرض على الزجاج الامامي HUD ، ليد داخلي متعدد الألوان ، كاميرا ٣٦٠ درجة ، جنوط ٢٠ ، مرايات ضم ، بالاضافة للمزيد من المواصفات الاساسية\r\n\r\nمتاح جميع انظمة التقسيط بصورة البطاقة ( بنوك وشركات ) بمقدم يبتدء من ١٠٪؜  \r\n\r\nالعنوان :٧٩ حافظ رمضان جانب النادي الاهلي ، مدينة نصر ، القاهرة\r\n",
                    Price = 1950000,
                    Prand = "Changan",

                    Rate = 5,
                    CarType = CarTypes.SUV
                  } ,



            });
        }
    }
}
