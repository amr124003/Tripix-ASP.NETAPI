using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class Tripconfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure ( EntityTypeBuilder<Trip> builder )
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.OwnsOne(e => e.PickupLocation);
            builder.OwnsOne(e => e.DestinationLocation);

            builder.Property(t => t.TripDate)
                .IsRequired();

            builder.Property(x => x.Status)
                .HasConversion<string>()
                .IsRequired();


        }
    }
}
