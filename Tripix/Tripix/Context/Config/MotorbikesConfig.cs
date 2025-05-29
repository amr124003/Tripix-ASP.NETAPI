using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class MotorbikesConfig : IEntityTypeConfiguration<Motorbikes>
    {
        public void Configure ( EntityTypeBuilder<Motorbikes> builder )
        {
            builder.Property(x => x.MotorbikeType)
                .HasConversion<string>();
        }
    }
}
