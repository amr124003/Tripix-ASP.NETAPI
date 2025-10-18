using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure ( EntityTypeBuilder<Vehicle> builder )
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.HasMany(x => x.VehicleImages)
                .WithOne(x => x.Vehicle)
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasDiscriminator<string>("VehicleType")
                .HasValue<Car>("Car")
                .HasValue<Motorbikes>("Motorbike")
                .HasValue<ElectricCars>("ElectricCar")
                .HasValue<UsedVehicle>("UsedCar");

            builder.Property(x => x.Status)
                .HasConversion<string>();
        }
    }
}
