namespace Strings
{
	class Strings
	{
		static void Main(string[] args)
		{
			// The '\' lets you put special characters.
			string qoutations = "My \"so-called\" life";
			// '\n' splits a string into 2 lines.
			string seperateLines = "This is \n2 seperate lines";
			// To use '\' as text just put another one behind it.
			string backwardSlash = "Go to c:\\programme files";
			// You can '@' to ignore all escape characters.
			string ignoreAll = @"Go to c:\programme files";
			// Use string.Format to use replacement indexes.
			string formatted = string.Format("My name is {0} and I am {1} years old", "Soumil", 13);
			// You can display money by putting ':C' is front of the index.
			// It will be in the users local format.
			string myMoney = string.Format("{0:C}", 54);
			// Putting ':N' formats the number with commas and decimals
			string numberFormated = string.Format("{0:N}", 738743843843463);
			// Use ':P' To display a number as a percentage
			string percentage = string.Format("{0} as a percentage: {0:P}", 0.36);
			// Use ':#' to display phone numbers. Each '#' with be replaced with phone digit.
			string phoneNumber = string.Format("Phone number: {0:(+##) ####-###-###}", 447423451894);
			// Use Substring to get a part of a string.
			// The firt number is the start character and the second number is the end character.
			// Leave it black to go to the end of the string.
			string songLyric = "I am at my all time low";
			songLyric = songLyric.Substring(8);

			Console.WriteLine(qoutations);
			Console.WriteLine(seperateLines);
			Console.WriteLine(backwardSlash);
			Console.WriteLine(ignoreAll);
			Console.WriteLine(formatted);
			Console.WriteLine(myMoney);
			Console.WriteLine(numberFormated);
			Console.WriteLine(percentage);
			Console.WriteLine(phoneNumber);
			Console.WriteLine(songLyric);
			Console.ReadLine();
		}
	}
}