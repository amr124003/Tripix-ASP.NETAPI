using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class LovedTipConfig : IEntityTypeConfiguration<LovedTips>
    {
        public void Configure(EntityTypeBuilder<LovedTips> builder)
        {
            builder.HasKey(x => new { x.TipId, x.UserId });

            builder.HasOne<ApplicationUser>()
                .WithMany(x => x.LovedTips)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(x => x.Tip)
                .WithMany(x => x.LovedTips)
                .HasForeignKey(x => x.TipId)
                .OnDelete(DeleteBehavior.NoAction); 

            builder.HasOne(x => x.User)
                .WithMany(x => x.LovedTips)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
