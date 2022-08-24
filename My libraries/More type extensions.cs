namespace MoreTypeExtensions
{
    public static class StringExtensions
    {
        static public string ReverseString(this string stringToReverse)
        {
            char[] stringToReverseCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringToReverseCharArray);
            return new string(stringToReverseCharArray);
        }

        public static bool ContainsCaseInsensitive(this string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}