using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class WashBookinConfig : IEntityTypeConfiguration<WashBooking>
    {
        public void Configure(EntityTypeBuilder<WashBooking> builder)
        {
            builder.Property(x => x.CarType)
                .HasConversion<string>();

            builder.Property(x => x.PricingPlan)
                .HasConversion<string>();
        }


    }
}
