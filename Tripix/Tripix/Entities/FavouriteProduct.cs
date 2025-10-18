namespace Tripix.Entities
{
    public class FavouriteProduct
    {   
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}