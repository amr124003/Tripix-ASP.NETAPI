using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class WashConfig : IEntityTypeConfiguration<WashBooking>
    {
        public void Configure ( EntityTypeBuilder<WashBooking> builder )
        {
            builder.HasOne<ApplicationUser>()
                .WithMany(x => x.WashBookings)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
