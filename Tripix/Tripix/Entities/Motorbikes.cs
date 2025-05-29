using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Motorbikes : Vehicle
    {
        public MotorbikeTypes? MotorbikeType { get; set; }
        public string Motor_Capacity { get; set; }
    }
}
