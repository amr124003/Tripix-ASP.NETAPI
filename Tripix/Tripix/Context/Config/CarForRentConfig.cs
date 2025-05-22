using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class CarForRentConfig : IEntityTypeConfiguration<CarsForrRent>
    {
        public void Configure ( EntityTypeBuilder<CarsForrRent> builder )
        {
            builder.Property(x => x.Status)
                .HasConversion<string>();
        }
    }
}
