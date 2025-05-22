using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class BrandConfig : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure ( EntityTypeBuilder<CarBrand> builder )
        {
            builder.HasData(new List<CarBrand>
            {
               new() { Id = 1, Name = "Toyota", NameAR = " ÊÌÊ «", Expand = false },
               new() { Id = 2, Name = "Hyundai", NameAR = "ÂÌÊ‰œ«Ì", Expand = false },
               new() { Id = 3, Name = "Nissan", NameAR = "‰Ì”«‰", Expand = false },
               new() { Id = 4, Name = "Kia", NameAR = "ﬂÌ«", Expand = false },
               new() { Id = 5, Name = "Chevrolet", NameAR = "‘Ì›—Ê·ÌÂ", Expand = false },
               new() { Id = 6, Name = "Mercedes", NameAR = "„—”Ìœ”", Expand = false },
               new() { Id = 7, Name = "BMW", NameAR = "»Ì ≈„ œ»·ÌÊ", Expand = false },
               new() { Id = 8, Name = "Honda", NameAR = "ÂÊ‰œ«", Expand = false },
               new() { Id = 9, Name = "Ford", NameAR = "›Ê—œ", Expand = false },
               new() { Id = 10, Name = "Jeep", NameAR = "ÃÌ»", Expand = false },
               new() { Id = 11, Name = "Audi", NameAR = "√ÊœÌ", Expand = false },
               new() { Id = 12, Name = "Mazda", NameAR = "„«“œ«", Expand = false },
               new() { Id = 13, Name = "Land Rover", NameAR = "·«‰œ —Ê›—", Expand = false },
               new() { Id = 14, Name = "Porsche", NameAR = "»Ê—‘", Expand = false },
               new() { Id = 15, Name = "Lexus", NameAR = "·ﬂ“”", Expand = false },
               new() { Id = 16, Name = "Jaguar", NameAR = "Ã«ﬂÊ«—", Expand = false },
               new() { Id = 17, Name = "Volvo", NameAR = "›Ê·›Ê", Expand = false },
               new() { Id = 18, Name = "Mitsubishi", NameAR = "„Ì ”Ê»Ì‘Ì", Expand = false },
               new() { Id = 19, Name = "Subaru", NameAR = "”Ê»«—Ê", Expand = false },
               new() { Id = 20, Name = "Peugeot", NameAR = "»ÌÃÊ", Expand = false },
               new() { Id = 21, Name = "Renault", NameAR = "—Ì‰Ê", Expand = false },
               new() { Id = 22, Name = "Fiat", NameAR = "›Ì« ", Expand = false },
               new() { Id = 23, Name = "Opel", NameAR = "√Ê»·", Expand = false },
               new() { Id = 24, Name = "Suzuki", NameAR = "”Ê“ÊﬂÌ", Expand = false },
               new() { Id = 25, Name = "Seat", NameAR = "”Ì« ", Expand = false },
               new() { Id = 26, Name = "MG", NameAR = "≈„ ÃÌ", Expand = false },
               new() { Id = 27, Name = "Geely", NameAR = "ÃÌ·Ì", Expand = false },
               new() { Id = 28, Name = "BYD", NameAR = "»Ì Ê«Ì œÌ", Expand = false },
               new() { Id = 29, Name = "JAC", NameAR = "Ã«ﬂ", Expand = false },
               new() { Id = 30, Name = "Chery", NameAR = "‘Ì—Ì", Expand = false },
               new() { Id = 31, Name = "Jetour", NameAR = "ÃÌ Ê—", Expand = false },
               new() { Id = 32, Name = "Speranza", NameAR = "”»Ì—«‰“«", Expand = false },
               new() { Id = 33, Name = "BAIC", NameAR = "»«Ìﬂ", Expand = false },
               new() { Id = 34, Name = "Daewoo", NameAR = "œ«ÌÊ", Expand = false },
               new() { Id = 35, Name = "Dongfeng", NameAR = "œÊ‰€ ›Ì‰€", Expand = false },
               new() { Id = 36, Name = "DFSK", NameAR = "œÌ ≈› ≈” ﬂÌÂ", Expand = false },
               new() { Id = 37, Name = "FAW", NameAR = "›«Ê", Expand = false },
               new() { Id = 38, Name = "Foton", NameAR = "›Ê Ê‰", Expand = false },
               new() { Id = 39, Name = "Lifan", NameAR = "·Ì›«‰", Expand = false },
               new() { Id = 40, Name = "Proton", NameAR = "»—Ê Ê‰", Expand = false },
               new() { Id = 41, Name = "Shalaby", NameAR = "‘·»Ì", Expand = false },
               new() { Id = 42, Name = "Dayun", NameAR = "œ«ÌÊ‰", Expand = false },
               new() { Id = 43, Name = "Volkswagen", NameAR = "›Ê·ﬂ” Ê«Ã‰", Expand = false },
               new() { Id = 44, Name = "Skoda", NameAR = "”ﬂÊœ«", Expand = false },
               new() { Id = 45, Name = "Tesla", NameAR = " ”·«", Expand = false },
               new() { Id = 46, Name = "Rivian", NameAR = "—Ì›Ì«‰", Expand = false },
               new() { Id = 47, Name = "Lucid Motors", NameAR = "·Ê”Ìœ „Ê Ê—“", Expand = false },
               new() { Id = 48, Name = "NIO", NameAR = "‰ÌÊ", Expand = false },
               new() { Id = 49, Name = "XPeng", NameAR = "≈ﬂ” »‰Ã", Expand = false },
               new() { Id = 50, Name = "Fisker", NameAR = "›Ì”ﬂ—", Expand = false },
               new() { Id = 51, Name = "Polestar", NameAR = "»Ê·” «—", Expand = false },
               new() { Id = 52, Name = "Faraday Future", NameAR = "›«—«œ«Ì ›ÌÊ ‘—", Expand = false },
               new() { Id = 53, Name = "VinFast", NameAR = "›Ì‰›«” ", Expand = false }
            });
        }
    }
}
