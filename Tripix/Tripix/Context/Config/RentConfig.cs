using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class RentConfig : IEntityTypeConfiguration<CarsForrRent>
    {
        public void Configure(EntityTypeBuilder<CarsForrRent> builder)
        {
            builder.HasData(new List<CarsForrRent>()
            {
                new CarsForrRent
                {
                    Id = 1,
                    CarName = "Kia EV5 2024",
                    CarColor = "Black",
                    CarImage = "/Images/Cars/Kia EV5 2024 6.WEBP",
                    CarDescription = "That Car Is Rented For One Day Only",
                    CarModel = "EV5",
                    CarRate = 3,
                    HourlyPrice = 100,
                    Status = CarForRentStatus.Avilable
                }
            });
        }
    }
}
