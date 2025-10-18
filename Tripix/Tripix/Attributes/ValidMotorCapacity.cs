using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Tripix.Attributes
{
    public class ValidMotorCapacity : ValidationAttribute
    {
        public ValidMotorCapacity()
        {
            ErrorMessage = "Motor capacity must be between 400 and 8000 CC (e.g., '1000 CC' or '1000 cc')";
        }
        public override bool IsValid(object value)
        {
            if(value == null) return false;

            if(value is string capacityValue)
            {
                var match = Regex.Match(capacityValue.Trim(), @"^(\d+)\s*[Cc]{2}$");

                if(!match.Success) { return false; }

                string[] values= capacityValue.Split(' ');

                var number = Convert.ToInt32(values[0]);

                if(number >= 400 && number <= 8000) return true;
                else return false;
            }
            return false;
        }
    }
}
