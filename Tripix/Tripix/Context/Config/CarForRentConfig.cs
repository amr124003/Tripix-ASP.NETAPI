using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class CarForRentConfig : IEntityTypeConfiguration<CarsForrRent>
    {
        public void Configure ( EntityTypeBuilder<CarsForrRent> builder )
        {
            builder.Property(x => x.Status)
                .HasConversion<string>();

            builder.HasData(
    new CarsForrRent
    {
        Id = 2,
        CarName = "Toyota Corolla",
        CarModel = "2022",
        CarColor = "White",
        CarRate = 4,
        CarDescription = "Comfortable sedan, fuel efficient, suitable for city rides.",
        CarImage = "/Images/CarForRent/car1.png",
        HourlyPrice = 120.00m,
        Status = CarForRentStatus.Avilable
    },
    new CarsForrRent
    {
        Id = 3,
        CarName = "Hyundai Elantra",
        CarModel = "2021",
        CarColor = "Black",
        CarRate = 5,
        CarDescription = "Sporty design with full options and automatic transmission.",
        CarImage = "/Images/CarForRent/car2.png",
        HourlyPrice = 130.00m,
        Status = CarForRentStatus.Avilable
    },
    new CarsForrRent
    {
        Id = 4,
        CarName = "Kia Sportage",
        CarModel = "2023",
        CarColor = "Gray",
        CarRate = 5,
        CarDescription = "Compact SUV, great for families and long trips.",
        CarImage = "/Images/CarForRent/car3.png",
        HourlyPrice = 180.00m,
        Status = CarForRentStatus.Avilable
    },
    new CarsForrRent
    {
        Id = 5,
        CarName = "Chevrolet Malibu",
        CarModel = "2020",
        CarColor = "Blue",
        CarRate = 3,
        CarDescription = "Spacious car with good trunk space, ideal for business trips.",
        CarImage = "/Images/CarForRent/car4.png",
        HourlyPrice = 100.00m,
        Status = CarForRentStatus.Avilable
    }
);

        }
    }
}
