using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class DriverConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure ( EntityTypeBuilder<Driver> builder )
        {
            builder.ToTable("Drivers");


            builder.OwnsOne(x => x.Location);

            builder.Property(x => x.Status)
                .HasConversion<string>();


            builder.HasOne<ApplicationUser>()
                .WithOne()
                .HasForeignKey<Driver>(x => x.Id);





        }
    }
}
