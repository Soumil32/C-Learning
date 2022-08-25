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

    public static class CharExtensions
    {
        public static string ConvertToString(this char[] charToConvert)
        {
            return new string(charToConvert);
        }
    }

    public static class IntExtensions
    {
        public static string ConvertToString(this int intToConvert)
        {
            return new string(intToConvert);
        }
    }
}