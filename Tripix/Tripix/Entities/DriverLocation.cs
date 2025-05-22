using Microsoft.EntityFrameworkCore;

namespace Tripix.Entities
{
    [Owned]
    public class DriverLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public DriverLocation ( double latitude, double longitude )
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
