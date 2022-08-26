namespace MoreTypeExtensions
{
	public static class StringExtensions
	{
		static public string ReverseString(this string stringToReverse)
		{
			char[] stringToReverseCharArray = stringToReverse.ToCharArray();
			Array.Reverse(stringToReverseCharArray);
			return String.Concat(stringToReverseCharArray);
		}

		public static bool ContainsCaseInsensitive(this string source, string substring)
		{
			return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
		}

		public static int ParseString(this string stringToParse)
		{
			return int.Parse(stringToParse);
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
		public static int? FindDuplicate(this int[] arrayToFindDuplicateIn)
		{
			int previousint = int.MaxValue;
			arrayToFindDuplicateIn = arrayToFindDuplicateIn.OrderByDescending(x => x).ToArray();

			foreach (int number in arrayToFindDuplicateIn)
			{
				if (number == previousint)
				{
					return number;
				}
				previousint = number;
			}
			return null;
		}
	}
}