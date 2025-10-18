using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class ComplainsConfig : IEntityTypeConfiguration<Complains>
    {
        public void Configure(EntityTypeBuilder<Complains> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.Complains)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}
