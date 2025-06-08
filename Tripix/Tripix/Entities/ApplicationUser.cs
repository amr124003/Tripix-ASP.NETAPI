using Microsoft.AspNetCore.Identity;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public bool IsDisabled { get; set; } = false;
        public List<RefreshTokens>? REFTokens { get; set; } = new();
        public List<VehicleBookings>? VehicleBookings { get; set; } = new();
        public List<FavouriteProduct> FavouriteProducts { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public List<Trip> Trips { get; set; } = new();
        public UserStatus UserStatus { get; set; } = UserStatus.Offline;
        public List<WashBooking> WashBookings { get; set; } = new();
        public List<RepairBookings> RepairBookings { get; set; } = new();
        public List<HelpooOrders> HelpooOrders { get; set; } = new();
        public List<CarRent> carRents { get; set; } = new();
        public List<EventTickets> EventTickets { get; set; } = new();
        public List<SparePartOrder> sparePartOrders { get; set; } = new();
        public List<JopApplications> JopApplications { get; set; } = new();
        public List<LovedTips> LovedTips { get; set; } = new();
        public List<TipComments> TipComments { get; set; } = new();
        public string? ConnectionId { get; set; }
    }
}
