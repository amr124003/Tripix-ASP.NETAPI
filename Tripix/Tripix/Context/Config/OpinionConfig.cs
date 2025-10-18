using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class OpinionConfig : IEntityTypeConfiguration<PassengerOpinion>
    {
        public void Configure(EntityTypeBuilder<PassengerOpinion> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.PassengerOpinion)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

           
        }
    }
}
