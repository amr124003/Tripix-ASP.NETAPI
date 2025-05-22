using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions.Consts;
using Tripix.Entities;

namespace Tripix.Context
{
    public class ApplicationDbcontext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbcontext ()
        {

        }

        public ApplicationDbcontext ( DbContextOptions<ApplicationDbcontext> options ) : base(options)
        {

        }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbcontext).Assembly);
            base.OnModelCreating(modelBuilder);


        }

        public override int SaveChanges ()
        {
            var deletedTrips = ChangeTracker.Entries<Trip>()
                .Where(e => e.State == EntityState.Deleted)
                .ToList();

            foreach (var trip in deletedTrips)
            {
                
                if (trip.Entity.Status == TripStatus.InProgress || trip.Entity.Status == TripStatus.Pending)
                {
                    throw new InvalidOperationException("Cannot delete an in-progress trip.");
                }
            }
            return base.SaveChanges();
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RefreshTokens> RefreshTokens { get; set; }
        public DbSet<BestSellervehicle> bestSellervehicles { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBookings> VehicleBookings { get; set; }
        public DbSet<VehicleImage> VehicleImages { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Jop> Jops { get; set; }
        public DbSet<JopApplications> JopApplications { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<CarsForrRent> CarsForrRents { get; set; }
        public DbSet<CarRent> CarRents { get; set; }
        public DbSet<RepairBookings> RepairBookings { get; set; }
        public DbSet<WashBooking> WashBookings { get; set; }
        public DbSet<BookingEventTicket> BookingEventTickets { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<HelpooOrders> HelpooOrders { get; set; }
        public DbSet<SparePartOrder> SparePartOrders { get; set; }
        public DbSet<SpareParts> SpareParts { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
