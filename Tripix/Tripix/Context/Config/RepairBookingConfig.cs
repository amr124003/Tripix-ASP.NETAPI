using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class RepairBookingConfig : IEntityTypeConfiguration<RepairBookings>
    {
        public void Configure(EntityTypeBuilder<RepairBookings> builder)
        {
            builder.Property(x => x.CarType)
                .HasConversion<string>();

            builder.Property(x => x.PricingPlan)
                .HasConversion<string>();
        }
    }
}
