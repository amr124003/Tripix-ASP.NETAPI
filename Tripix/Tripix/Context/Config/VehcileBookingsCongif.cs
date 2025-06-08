using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class VehcileBookingsCongif : IEntityTypeConfiguration<VehicleBookings>
    {
        public void Configure ( EntityTypeBuilder<VehicleBookings> builder )
        {
            builder.HasIndex(x => x.VehicleId)
                .HasDatabaseName("IX_VehicleBookings_VehicleId");
        }
    }
}
