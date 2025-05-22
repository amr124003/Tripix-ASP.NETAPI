using System.ComponentModel.DataAnnotations;

namespace Tripix.Extentions
{
    public static class ValidEmail
    {
        public static bool IsValidEmail(this string? Email)
        {
            return new EmailAddressAttribute().IsValid(Email);
        }
    }
}
