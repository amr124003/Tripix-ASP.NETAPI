using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure ( EntityTypeBuilder<ApplicationUser> builder )
        {
            builder.ToTable("AspNetUsers");

            builder.HasIndex(x => x.PhoneNumber).IsUnique();

            builder
          .HasDiscriminator<string>("UserType")
          .HasValue<ApplicationUser>("User")  // «·‰Ê⁄ «·√”«”Ì
          .HasValue<Driver>("Driver");

            


            builder
       .HasIndex(u => u.UserName)
       .HasDatabaseName("AspNetUsers.IX_Users_Username")
       .IsUnique(false); // ·Ê ⁄«Ì“  Œ·ÌÂ „‘ UniqueF





        }
    }
}
