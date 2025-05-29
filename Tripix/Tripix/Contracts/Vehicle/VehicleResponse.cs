using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.Vehicle
{
    public class VehicleResponse
    {
        public string Year { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Prand { get; set; }

        [AllowedValues("Used", "New")]
        public string Condition { get; set; }
    }
}
