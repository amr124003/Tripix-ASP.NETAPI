using System.ComponentModel.DataAnnotations.Schema;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class VehicleBookings
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public bookingCategory Category { get; set; }    
    }
}
