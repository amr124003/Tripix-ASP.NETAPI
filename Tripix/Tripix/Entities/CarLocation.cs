using Microsoft.EntityFrameworkCore;

namespace Tripix.Entities
{
    [Owned]
    public class CarLocation
    {
        public CarLocation ( double latitude, double longitude )
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
