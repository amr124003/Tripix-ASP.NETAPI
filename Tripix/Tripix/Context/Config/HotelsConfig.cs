using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class HotelsConfig : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.Property(x => x.GovernateName)
                .HasConversion<string>();

            builder.HasData(new List<Hotel>
            {
                new Hotel
                {
                    Id = 1,
                    Name = "Four Seasons Hotel Cairo at Nile Plaza",
                    Address = "1089 Corniche El Nil, Garden City, Cairo 11519, Egypt",
                    Description = "A luxurious hotel overlooking the Nile River, featuring spacious and elegantly furnished rooms, a world-class spa, multiple fine-dining restaurants, and proximity to the Egyptian Museum and downtown Cairo.",
                    Rate = 4,
                    StartPrice = 9870,
                    GovernateName = Governates.Cairo
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Ramses Hilton Hotel & Casino",
                    Address = "1115 Corniche El Nile, Bulaq, Downtown Cairo, Egypt",
                    Description = "A high-rise hotel with views of the Nile, casino, pool, gym, and easy access to Tahrir Square and the Egyptian Museum",
                    Rate = 3,
                    StartPrice = 5640,
                    GovernateName = Governates.Cairo
                },
                new Hotel
                {
                    Id = 3,
                    Name = " The St. Regis Cairo",
                    Address = " 1189 Nile Corniche, Downtown Cairo, Egypt 11221",
                    Description = "Ultra-modern, luxury hotel with butler service, gourmet restaurants, pools, and a world-class spa",
                    Rate = 4,
                    StartPrice = 14100,
                    GovernateName = Governates.Cairo
                },
                new Hotel
                {
                    Id = 4,
                    Name = " Four Seasons Hotel Alexandria at San Stefano",
                    Address = "399 El Geish Road, San Stefano Grand Plaza, Alexandria 21599, Egypt",
                    Description = "A luxury resort-style hotel set between the Mediterranean Sea and the city. Features include a private beach, three pools (indoor heated and outdoor infinity), full spa (14 treatment rooms), squash court, multiple fine-dining restaurants, and beachfront access with spectacular sea views",
                    Rate = 4,
                    StartPrice = 14300 ,
                    GovernateName = Governates.Alex
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Helnan Royal Palestine Hotel – Montazah Gardens",
                    Address = " Al Montazah Palace, Montazah Gardens, Alexandria, Egypt",
                    Description = "Historic beachfront hotel nestled in lush Montazah Gardens. Offers a private beach, outdoor pool, spa, fitness center, and several restaurants. Spacious, sea-facing balconies (some overlooking Montazah Palace). Surrounded by a serene garden reserve .",
                    Rate = 3,
                    StartPrice = 5640 ,
                    GovernateName = Governates.Alex
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Steigenberger Cecil Alexandria Hotel",
                    Address = " 16 Saad Zagloul Square, Raml Station, Alexandria 11015, Egypt",
                    Description = "A classic 4-star historic hotel (opened in 1929), recently renovated. Located in downtown, steps from the Corniche and cultural landmarks. Offers free Wi‑Fi, restaurant, balconies, minibar, and multilingual staff",
                    Rate = 3,
                    StartPrice = 4230 ,
                    GovernateName = Governates.Alex
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Steigenberger ALDAU Beach Hotel",
                    Address = " Yussif Afifi Road – El Mamsha El Seyahi, Hurghada",
                    Description = "A luxury 5-star, all-inclusive beachfront resort with outstanding service and family facilities",
                    Rate = 4,
                    StartPrice = 11421 ,
                    GovernateName = Governates.Hurghada
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Jaz Aquaviva (formerly Jaz Aquaviva & Jaz Casa Del Mar Beach)",
                    Address = " Madinat Makadi area, Hurghada",
                    Description = "Features Egypt's largest water park (~50 rides), private beach, multiple pools, spa, kids' club, and buffet/a‑la‑carte dining",
                    Rate = 4,
                    StartPrice = 20586 ,
                    GovernateName = Governates.Hurghada
                },
                new Hotel
                {
                    Id = 9,
                    Name = "Steigenberger Nile Palace Luxor",
                    Address = " East Bank, Luxor",
                    Description = "A luxury 5-star resort with Nile views, outdoor pool, fitness center, spa, and on-site restaurants",
                    Rate = 3,
                    StartPrice = 3243 ,
                    GovernateName = Governates.Luxor
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Sofitel Winter Palace Luxor",
                    Address = " East Bank, on the Nile, near Luxor Temple",
                    Description = "Iconic historic palace hotel (since 1907) with Victorian style, lush gardens, premium restaurants, and pool",
                    Rate = 4,
                    StartPrice = 9870 ,
                    GovernateName = Governates.Luxor
                }

            });
        }
    }
}
