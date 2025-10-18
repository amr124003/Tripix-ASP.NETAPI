using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class EventsConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasData(new List<Event>(){
                new Event
                {
                    Id = 1,
                    Title = "Cairo Motor Show 2025",
                    Location = "Egypt International Exhibition Center",
                    Date = new DateTime(2025 , 10 , 15),
                    Image = "/Images/Events/DALL·E 2025-02-08 05.45.57 - A vibrant car event during the daytime, with people gathered around modern and classic cars, enjoying the atmosphere under a sunny blue sky. The scene.webp",
                    Content = "This Event Is For All Users You Can Now Book Ticket And Take It To Meet Most And Important Car Character"
                }
            });
        }
    }
}
