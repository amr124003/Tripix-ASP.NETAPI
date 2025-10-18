using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Car : Vehicle
    {
        public CarTypes? CarType { get; set; }
        public string Motor_Capacity { get; set; }
    }
}
