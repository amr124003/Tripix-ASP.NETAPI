using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal StartPrice {  get; set; }
        public Governates GovernateName { get; set; }
        public List<HotleImages> HotelImage { get; set; }
    }
}
