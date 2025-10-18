using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Vehicle
{
    public class VehicleDTO
    {
        public int VehicleId { get; set; } 
        public bookingCategory VehicleCategory { get; set; }
    }
}