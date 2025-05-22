namespace Tripix.Extentions
{
    public static class GetUserName
    {
        public static string GetUserNameFromEmail (this string Email)
        {
            if(string.IsNullOrEmpty(Email) || !Email.IsValidEmail())
            {
                throw new ArgumentException("Invalid Email");
            }

            return Email.Split('@')[0];
        }
    }
}
