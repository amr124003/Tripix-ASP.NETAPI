using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure ( EntityTypeBuilder<ApplicationUser> builder )
        {
            builder.ToTable("AspNetUsers");

            builder.HasIndex(x => x.PhoneNumber).IsUnique();






        }
    }
}
