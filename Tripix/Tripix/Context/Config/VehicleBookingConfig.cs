using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class VehicleBookingConfig : IEntityTypeConfiguration<VehicleBookings>
    {
        public void Configure(EntityTypeBuilder<VehicleBookings> builder)
        {
            builder.Property(x => x.Category)
                .HasConversion<string>();
        }
    }
}
