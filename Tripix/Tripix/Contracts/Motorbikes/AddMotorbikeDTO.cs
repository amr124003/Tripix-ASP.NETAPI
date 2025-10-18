using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Motorbikes
{
    public class AddMotorbikeDTO
    {
        public string MotorbikeName { get; set; }
        public string MotorbikeYear { get; set; }
        public string MotorbikeModel { get; set; }
        public string MotorbikePrand { get; set; }
        public GearboxTypes Gearbox_Type { get; set; }
        public string MotorbikeDescription { get; set; }
        public List<IFormFile> Images { get; set; }
        public decimal MotorbikePrice { get; set; }
        public MotorbikeTypes MotorbikeTypes { get; set; }
        public int? Rate { get; set; }
        public string Motor_Capacity { get; set; }
        public decimal? Discount { get; set; }
    }
}
