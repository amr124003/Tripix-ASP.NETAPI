namespace Tripix.Entities
{
    public class SparePartOrder
    {
        public  int Id { get; set; }
        public string SparePartId { get; set; } 
        public SpareParts SpareParts { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }
        public string OrderDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
