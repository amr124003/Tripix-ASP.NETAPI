namespace Tripix.Extentions
{
    public static class GetName
    {
        public static string? GetNameFromUserName ( this string? UserName )
        {
            var onlyLetters = new string(UserName
                .Where(char.IsLetter)
                .ToArray());


            if (string.IsNullOrWhiteSpace(onlyLetters))
                return "User";

            return char.ToUpper(onlyLetters[0]) + onlyLetters.Substring(1).ToLower();
        }

    }
}
