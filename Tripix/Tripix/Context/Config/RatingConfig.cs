using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class RatingConfig : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.RatesAdded)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

             
        }
    }
}
