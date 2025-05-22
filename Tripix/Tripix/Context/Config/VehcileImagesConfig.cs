using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tripix.Entities;

namespace Tripix.Context.Config
{
    public class VehcileImagesConfig : IEntityTypeConfiguration<VehicleImage>
    {
        public void Configure ( EntityTypeBuilder<VehicleImage> builder )
        {
            builder.HasData(new List<VehicleImage>
            {
                 new() {
                        Id = 1,
                        VehicleId = 1,
                        ImageUrl = "/Images/Cars/Mercedes-Benz 1.WEBP"
                        },
                        new() {
                            Id = 2,
                            VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 2.WEBP"
                        },
                        new() {
                            Id = 3,
                            VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 3.WEBP"
                        },
                          new() {
                              Id = 4,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 4.WEBP"
                        },
                          new() {
                              Id = 5,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 5.WEBP"
                        },
                          new() {
                              Id = 6,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 6.WEBP"
                        },
                          new() {
                              Id = 7,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 7.WEBP"
                        },
                          new() {
                              Id = 8,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 8.WEBP"
                        },
                          new() {
                              Id = 9,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 9.WEBP"
                        },
                          new() {
                              Id = 10,
                              VehicleId = 1,
                            ImageUrl = "/Images/Cars/Mercedes-Benz 10.WEBP"
                        } ,
                          new() {
                              Id = 11,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 1.WEBP"
                        },
                        new() {
                            Id = 12,
                            VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 2.WEBP"
                        },
                        new() {
                            Id = 13,
                            VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 3.WEBP"
                        },
                          new() {
                              Id = 14,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 4.WEBP"
                        },
                          new() {
                              Id = 15,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 5.WEBP"
                        },
                          new() {
                              Id = 16,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 6.WEBP"
                        },
                          new() {
                              Id = 17,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 7.WEBP"
                        },
                          new() {
                              Id = 18,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 8.WEBP"
                        },
                          new() {
                              Id = 19,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 9.WEBP"
                        },
                          new() {
                              Id = 20,
                              VehicleId = 2,
                            ImageUrl = "/Images/Cars/MERCEDES MAYBACH 10.WEBP"
                        },
                          new() {
                              Id = 21,
                              VehicleId = 3,
                            ImageUrl = "/Images/Cars/Toyota W251.WEBP"
                        },
                        new() {
                            Id = 22,
                            VehicleId = 3,
                            ImageUrl = "/Images/Cars/Toyota W252.WEBP"
                        },
                        new() {
                            Id = 23,
                            VehicleId = 3,
                            ImageUrl = "/Images/Cars/Toyota W254.WEBP"
                        },
                          new() {
                              Id = 24,
                              VehicleId = 3,
                            ImageUrl = "/Images/Cars/Toyota W255.WEBP"
                        },
                          new() {
                              Id = 25,
                              VehicleId = 3,
                            ImageUrl = "/Images/Cars/Toyota W256.WEBP"
                        } ,
                          new() {
                              Id = 26,
                              VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 1.WEBP"
                        },
                        new() {
                            Id = 27,
                            VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 2.WEBP"
                        },
                        new() {
                            Id = 28,
                            VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 3.WEBP"
                        },
                          new() {
                              Id = 29,
                              VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 4.WEBP"
                        },
                          new() {
                              Id = 30,
                              VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 5.WEBP"
                        },
                            new() {
                                Id = 31 ,
                                VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 6.WEBP"
                        },
                            new() {
                                Id = 32,
                                VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 7.WEBP"
                        },
                            new() {
                                Id = 33,
                                VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 8.WEBP"
                        },
                            new() {
                                Id = 34,
                                VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 9.WEBP"
                        },
                            new() {
                                Id = 35,
                                VehicleId = 4,
                            ImageUrl = "/Images/Cars/Mercedes-Benz GLC 10.WEBP"
                        },
                             new() {
                                 Id = 36 ,
                                 VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 1.WEBP"
                        },

                         new() {
                             Id = 38,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 2.WEBP"
                        },
                         new() {
                             Id = 39,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 3.WEBP"
                        },
                         new() {
                             Id = 40,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 4.WEBP"
                        },
                         new() {
                             Id = 41 ,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 5.WEBP"
                        },
                         new() {
                             Id = 42 ,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 6.WEBP"
                        },
                         new() {
                             Id = 43 ,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 7.WEBP"
                        },
                         new() {
                             Id = 44 ,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 8.WEBP"
                        },
                         new() {
                             Id = 45 ,
                             VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 9.WEBP"
                        },
                            new() {
                                Id = 46,
                                VehicleId = 5,
                            ImageUrl = "/Images/Cars/Mercedes Benz E200 10.WEBP"
                        },
                          new() {
                              Id = 47,
                              VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 1.WEBP"
                        },
                        new() {
                            Id = 48 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 2.WEBP"
                        },
                        new() {
                            Id = 49,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 3.WEBP"
                        },
                        new() {
                            Id = 50 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 4.WEBP"
                        },
                        new() {
                            Id = 51,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 5.WEBP"
                        },
                        new() {
                            Id = 52,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 6.WEBP"
                        },
                        new() {
                            Id = 53 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 7.WEBP"
                        },
                        new() {
                            Id = 54 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 8.WEBP"
                        },
                        new() {
                            Id = 55 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 9.WEBP"
                        },
                        new() {
                            Id = 56 ,
                            VehicleId = 6,
                            ImageUrl = "/Images/Cars/Volkswagen ID6 Crozz Pro 10.WEBP"
                        },
                         new() {
                             Id = 57 ,
                             VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 1.WEBP"
                        },
                        new() {
                            Id = 58,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 2.WEBP"
                        },
                        new() {
                            Id = 59,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 3.WEBP"
                        },
                        new() {
                            Id = 60 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 4.WEBP"
                        },
                        new() {
                            Id = 61,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 5.WEBP"
                        },
                        new() {
                            Id = 62 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 6.WEBP"
                        },
                        new() {
                            Id = 63 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 7.WEBP"
                        },
                        new() {
                            Id = 64 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 8.WEBP"
                        },
                        new() {
                            Id = 65 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 9.WEBP"
                        },
                        new() {
                            Id = 66 ,
                            VehicleId = 7,
                            ImageUrl = "/Images/Cars/Porsche Taycan 2024 10.WEBP"
                        },
                        new()
                        {
                            Id = 67 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 1.WEBP"
                        } ,
                        new() {
                            Id = 68 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 2.WEBP"
                        },
                        new() {
                            Id = 69 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 3.WEBP"
                        },
                        new() {
                            Id = 70 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 4.WEBP"
                        },
                        new() {
                            Id = 71 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 5.WEBP"
                        },
                        new() {
                            Id = 72 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 6.WEBP"
                        },
                        new() {
                            Id = 73 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 7.WEBP"
                        },
                        new() {
                            Id = 74 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 8.WEBP"
                        },
                        new() {
                            Id = 75 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 9.WEBP"
                        },
                        new() {
                            Id = 76 ,
                            VehicleId = 8,
                            ImageUrl = "/Images/Cars/Range Rover Velar 2025 10.WEBP"
                        },
                        new() {
                            Id = 77 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 1.WEBP"
                        } ,
                        new() {
                            Id = 78 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 2.WEBP"
                        },
                        new() {
                            Id = 79 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 3.WEBP"
                        },
                        new() {
                            Id = 80 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 4.WEBP"
                        },
                        new() {
                            Id = 81 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 5.WEBP"
                        },
                        new() {
                            Id = 82 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 6.WEBP"
                        },
                        new() {
                            Id = 83 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 7.WEBP"
                        },
                        new() {
                            Id = 84 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 8.WEBP"
                        },
                        new() {
                            Id = 85 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 9.WEBP"
                        },
                        new() {
                            Id = 86 ,
                            VehicleId = 9,
                            ImageUrl = "/Images/Cars/Skoda Kodiaq 2024 Laurin & Klement 10.WEBP"
                        },
                        new() {
                            Id = 87 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 1.WEBP"
                        } ,
                        new() {
                            Id = 88 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 2.WEBP"
                        },
                        new() {
                            Id = 89 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 3.WEBP"
                        },
                        new() {
                            Id = 90 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 4.WEBP"
                        },
                        new() {
                            Id = 91 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 5.WEBP"
                        },
                        new() {
                            Id = 92 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 6.WEBP"
                        },
                        new() {
                            Id = 93 ,
                            VehicleId = 10,
                            ImageUrl = "/Images/Cars/Porsche Macan 2024 7.WEBP"
                        },
                        new() {
                            Id = 94 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 1.WEBP"
                        },
                        new() {
                            Id = 95 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 2.WEBP"
                        },
                        new() {
                            Id = 96 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 3.WEBP"
                        },
                        new() {
                            Id = 97 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 4.WEBP"
                        },
                        new() {
                            Id = 98 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 5.WEBP"
                        },
                        new() {
                            Id = 99 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 6.WEBP"
                        },
                        new() {
                            Id = 100 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 7.WEBP"
                        },
                        new() {
                            Id = 101 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 8.WEBP"
                        },
                        new() {
                            Id = 102 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 9.WEBP"
                        },
                        new() {
                            Id = 103 ,
                            VehicleId = 11,
                            ImageUrl = "/Images/Cars/Hyundai Elantra 2025 10.WEBP"
                        },
                        new() {
                            Id = 104 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 1.WEBP"
                        } ,
                        new() {
                            Id = 105 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 2.WEBP"
                        },
                        new() {
                            Id = 106 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 3.WEBP"
                        },
                        new() {
                            Id = 107 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 4.WEBP"
                        },
                        new() {
                            Id = 108 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 5.WEBP"
                        },
                        new() {
                            Id = 109 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 6.WEBP"
                        },
                        new() {
                            Id = 110 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 7.WEBP"
                        },
                        new() {
                            Id = 111 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 8.WEBP"
                        },
                        new() {
                            Id = 112 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 9.WEBP"
                        },
                        new() {
                            Id = 113 ,
                            VehicleId = 12,
                            ImageUrl = "/Images/Cars/Kia EV5 2024 10.WEBP"
                        },
                        new() {
                            Id = 114 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 1.WEBP"
                        } ,
                        new() {
                            Id = 115 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 2.WEBP"
                        },
                        new() {
                            Id = 116 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 3.WEBP"
                        },
                        new() {
                            Id = 117 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 4.WEBP"
                        },
                        new() {
                            Id = 118 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 5.WEBP"
                        },
                        new() {
                            Id = 119 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 6.WEBP"
                        },
                        new()
                        {
                            Id = 120 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 7.WEBP"
                        },
                        new()
                        {
                            Id = 121 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 8.WEBP"
                        },
                        new()
                        {
                            Id = 122 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 9.WEBP"
                        },
                        new()
                        {
                            Id = 123 ,
                            VehicleId = 13,
                            ImageUrl = "/Images/Cars/RANGE ROVE EVOQUE 2021 10.WEBP"
                        },
                        new()
                        {
                            Id = 124 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 1.WEBP"
                        },
                        new()
                        {
                            Id = 125 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 2.WEBP"
                        },
                        new()
                        {
                            Id = 126 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 3.WEBP"
                        },
                        new()
                        {
                            Id = 127 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 4.WEBP"
                        },
                        new()
                        {
                            Id = 128 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 5.WEBP"
                        },
                        new()
                        {
                            Id = 129 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 6.WEBP"
                        },
                        new()
                        {
                            Id = 130 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 7.WEBP"
                        },
                        new()
                        {
                            Id = 131 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 8.WEBP"
                        },
                        new()
                        {
                            Id = 132 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 9.WEBP"
                        },
                        new()
                        {
                            Id = 133 ,
                            VehicleId = 14,
                            ImageUrl = "/Images/Cars/MG RX5 2024 10.WEBP"
                        },
                        new()
                        {
                            Id = 134 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 1.WEBP"
                        },
                        new()
                        {
                            Id = 135 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 2.WEBP"
                        },
                        new()
                        {
                            Id = 136 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 3.WEBP"
                        },
                        new()
                        {
                            Id = 137 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 4.WEBP"
                        },
                        new()
                        {
                            Id = 138 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 5.WEBP"
                        },
                        new()
                        {
                            Id = 139 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 6.WEBP"
                        },
                        new()
                        {
                            Id = 140 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 7.WEBP"
                        },
                        new()
                        {
                            Id = 141 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 8.WEBP"
                        },
                        new()
                        {
                            Id = 142 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 9.WEBP"
                        },
                        new()
                        {
                            Id = 143 ,
                            VehicleId = 15,
                            ImageUrl = "/Images/Cars/Audi Q4 E-Tron 2024 10.WEBP"
                        },
                        new()
                        {
                            Id = 144 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 1.WEBP"
                        },
                        new()
                        {
                            Id = 145 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 2.WEBP"
                        },
                        new()
                        {
                            Id = 146 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 3.WEBP"
                        },
                        new()
                        {
                            Id = 147 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 4.WEBP"
                        },
                        new()
                        {
                            Id = 148 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 5.WEBP"
                        },
                        new()
                        {
                            Id = 149 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 6.WEBP"
                        },
                        new()
                        {
                            Id = 150 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 7.WEBP"
                        },
                        new()
                        {
                            Id = 151 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 8.WEBP"
                        },
                        new()
                        {
                            Id = 152 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 9.WEBP"
                        },
                        new()
                        {
                            Id = 153 ,
                            VehicleId = 16,
                            ImageUrl = "/Images/Cars/Changan S7 FULL ELECTRIC 2024 10.WEBP"
                        },
                        new()
                        {
                            Id = 154 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 1.WEBP"
                        },
                        new()
                        {
                            Id = 155 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 2.WEBP"
                        },
                        new()
                        {
                            Id = 156 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 3.WEBP"
                        },
                        new()
                        {
                            Id = 157 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 4.WEBP"
                        },
                        new()
                        {
                            Id = 158 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 5.WEBP"
                        },
                        new()
                        {
                            Id = 159 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 6.WEBP"
                        },
                        new()
                        {
                            Id = 160 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 7.WEBP"
                        },
                        new()
                        {
                            Id = 161 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 8.WEBP"
                        },
                        new()
                        {
                            Id = 162 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 9.WEBP"
                        },
                        new()
                        {
                            Id = 163 ,
                            VehicleId = 17,
                            ImageUrl = "/Images/Cars/BMW X6 M50i2017 10.WEBP"
                        },
                        new()
                        {
                            Id = 164 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 1.WEBP"
                        },
                        new()
                        {
                            Id = 165 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 2.WEBP"
                        },
                        new()
                        {
                            Id = 166 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 3.WEBP"
                        },
                        new()
                        {
                            Id = 167 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 4.WEBP"
                        },
                        new()
                        {
                            Id = 168 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 5.WEBP"
                        },
                        new()
                        {
                            Id = 169 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 6.WEBP"
                        },
                        new()
                        {
                            Id = 170 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 7.WEBP"
                        },
                        new()
                        {
                            Id = 171 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 8.WEBP"
                        },
                        new()
                        {
                            Id = 172 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 9.WEBP"
                        },
                        new()
                        {
                            Id = 173 ,
                            VehicleId = 18,
                            ImageUrl = "/Images/Cars/Jaguar F-type 2021 mti 10.WEBP"
                        },
                        new()
                        {
                            Id = 174 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 1.WEBP"
                        },
                        new()
                        {
                            Id = 175 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 2.WEBP"
                        },
                        new()
                        {
                            Id = 176 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 3.WEBP"
                        },
                        new()
                        {
                            Id = 177 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 4.WEBP"
                        },
                        new()
                        {
                            Id = 178 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 5.WEBP"
                        },
                        new()
                        {
                            Id = 179 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 6.WEBP"
                        },
                        new()
                        {
                            Id = 180 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 7.WEBP"
                        },
                        new()
                        {
                            Id = 181 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 8.WEBP"
                        },
                        new()
                        {
                            Id = 182 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 9.WEBP"
                        },
                        new()
                        {
                            Id = 183 ,
                            VehicleId = 19,
                            ImageUrl = "/Images/Cars/BMW 750 Li 2009 10.WEBP"
                        },
                        new()
                        {
                            Id = 184 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 1.WEBP"
                        },
                        new()
                        {
                            Id = 185 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 2.WEBP"
                        },
                        new()
                        {
                            Id = 186 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 3.WEBP"
                        },
                        new()
                        {
                            Id = 187 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 4.WEBP"
                        },
                        new()
                        {
                            Id = 188 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 5.WEBP"
                        },
                        new()
                        {
                            Id = 189 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 6.WEBP"
                        },
                        new()
                        {
                            Id = 190 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 7.WEBP"
                        },
                        new()
                        {
                            Id = 191 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 8.WEBP"
                        },
                        new()
                        {
                            Id = 192 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 9.WEBP"
                        },
                        new()
                        {
                            Id = 193 ,
                            VehicleId = 20,
                            ImageUrl = "/Images/Cars/Audi Q3 sportback 2024 10.WEBP"
                        },
                        new()
                        {
                            Id = 194 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 1.WEBP"
                        },
                        new()
                        {
                            Id = 195 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 2.WEBP"
                        },
                        new()
                        {
                            Id = 196 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 3.WEBP"
                        },
                        new()
                        {
                            Id = 197 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 4.WEBP"
                        },
                        new()
                        {
                            Id = 198 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 5.WEBP"
                        },
                        new()
                        {
                            Id = 199 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 6.WEBP"
                        },
                        new()
                        {
                            Id = 200 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 7.WEBP"
                        },
                        new()
                        {
                            Id = 201 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 8.WEBP"
                        },
                        new()
                        {
                            Id = 202 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 9.WEBP"
                        },
                        new()
                        {
                            Id = 203 ,
                            VehicleId = 21,
                            ImageUrl = "/Images/Cars/Mercedes-Benz C180 2009 10.WEBP"
                        },
                        new()
                        {
                            Id = 204 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 1.WEBP"
                        },
                        new()
                        {
                            Id = 205 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 2.WEBP"
                        },
                        new()
                        {
                            Id = 206 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 3.WEBP"
                        },
                        new()
                        {
                            Id = 207 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 4.WEBP"
                        },
                        new()
                        {
                            Id = 208 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 5.WEBP"
                        },
                        new()
                        {
                            Id = 209 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 6.WEBP"
                        },
                        new()
                        {
                            Id = 210 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 7.WEBP"
                        },
                        new()
                        {
                            Id = 211 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 8.WEBP"
                        },
                        new()
                        {
                            Id = 212 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 9.WEBP"
                        },
                        new()
                        {
                            Id = 213 ,
                            VehicleId = 22,
                            ImageUrl = "/Images/Cars/Mercedes-Benz G63 2022 AMG 10.WEBP"
                        }
            });
        }
    }
}
