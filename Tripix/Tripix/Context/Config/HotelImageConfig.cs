using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class HotelImageConfig : IEntityTypeConfiguration<HotleImages>
    {
        public void Configure(EntityTypeBuilder<HotleImages> builder)
        {
            builder.HasData(new List<HotleImages>
              {
                  new HotleImages { Id = 1, HotelId = 1, ImageUrl = "Images/h11.jpg" },
                  new HotleImages { Id = 2, HotelId = 1, ImageUrl = "Images/h12.jpg" },
                  new HotleImages { Id = 3, HotelId = 1, ImageUrl = "Images/h13.jpg" },
              
                  new HotleImages { Id = 4, HotelId = 2, ImageUrl = "Images/h21.jpg" },
                  new HotleImages { Id = 5, HotelId = 2, ImageUrl = "Images/h22.jpg" },
                  new HotleImages { Id = 6, HotelId = 2, ImageUrl = "Images/h23.jpg" },
              
                  new HotleImages { Id = 7, HotelId = 3, ImageUrl = "Images/h31.jpg" },
                  new HotleImages { Id = 8, HotelId = 3, ImageUrl = "Images/h32.jpg" },
                  new HotleImages { Id = 9, HotelId = 3, ImageUrl = "Images/h33.jpg" },
              
                  new HotleImages { Id = 10, HotelId = 4, ImageUrl = "Images/h41.jpg" },
                  new HotleImages { Id = 11, HotelId = 4, ImageUrl = "Images/h42.jpg" },
                  new HotleImages { Id = 12, HotelId = 4, ImageUrl = "Images/h43.jpg" },
              
                  new HotleImages { Id = 13, HotelId = 5, ImageUrl = "Images/h51.jpg" },
                  new HotleImages { Id = 14, HotelId = 5, ImageUrl = "Images/h52.jpg" },
                  new HotleImages { Id = 15, HotelId = 5, ImageUrl = "Images/h53.jpg" },
              
                  new HotleImages { Id = 16, HotelId = 6, ImageUrl = "Images/h61.jpg" },
                  new HotleImages { Id = 17, HotelId = 6, ImageUrl = "Images/h62.jpg" },
                  new HotleImages { Id = 18, HotelId = 6, ImageUrl = "Images/h63.jpg" },
              
                  new HotleImages { Id = 19, HotelId = 7, ImageUrl = "Images/h71.jpg" },
                  new HotleImages { Id = 20, HotelId = 7, ImageUrl = "Images/h72.jpg" },
                  new HotleImages { Id = 21, HotelId = 7, ImageUrl = "Images/h73.jpg" },
              
                  new HotleImages { Id = 22, HotelId = 8, ImageUrl = "Images/h81.jpg" },
                  new HotleImages { Id = 23, HotelId = 8, ImageUrl = "Images/h82.jpg" },
                  new HotleImages { Id = 24, HotelId = 8, ImageUrl = "Images/h83.jpg" },
              
                  new HotleImages { Id = 25, HotelId = 9, ImageUrl = "Images/h91.jpg" },
                  new HotleImages { Id = 26, HotelId = 9, ImageUrl = "Images/h92.jpg" },
                  new HotleImages { Id = 27, HotelId = 9, ImageUrl = "Images/h93.jpg" },
              
                  new HotleImages { Id = 28, HotelId = 10, ImageUrl = "Images/h101.jpg" },
                  new HotleImages { Id = 29, HotelId = 10, ImageUrl = "Images/h102.jpg" },
                  new HotleImages { Id = 30, HotelId = 10, ImageUrl = "Images/h103.jpg" },
              });

        }
    }
}
