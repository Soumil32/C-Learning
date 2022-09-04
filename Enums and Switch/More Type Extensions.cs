// ReSharper disable once CheckNamespace

namespace MoreTypeExtensions
{
    public static class StringExtensions
    {
        public static string ReverseString(this string stringToReverse)
        {
            char[] stringToReverseCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringToReverseCharArray);
            return new string(stringToReverseCharArray);
        }

        public static bool IgnoreCaseContains(this string source, string substring)
        {
            return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }

    public static class CharExtensions
    {
        
    }

    public static class IntExtensions
    {
        public static int? FindDuplicate(this int[] arrayToFindDuplicateIn)
        {
            int prevoiusInt = int.MaxValue;
            arrayToFindDuplicateIn = arrayToFindDuplicateIn.OrderByDescending(x => x).ToArray();

            foreach (int number in arrayToFindDuplicateIn)
            {
                if (number == prevoiusInt)
                {
                    return number;
                }
                prevoiusInt = number;
            }
            return null;
        }
    }
}