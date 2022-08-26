namespace DatesAndTimes
{
	class DatesAndTimes
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine(now);
			Console.WriteLine("Short date: " + now.ToShortDateString());
			Console.WriteLine("Long date: " + now.ToLongDateString());
			Console.WriteLine("Short time: " + now.ToShortTimeString());
			Console.WriteLine("Long time: " + now.ToLongTimeString());

			Console.WriteLine("The date 2 days today is " + now.AddDays(2).ToLongDateString());
			Console.WriteLine("Time 2 hours from now is " + now.AddHours(2).ToShortTimeString());
			Console.WriteLine("The date 2 days ago was " + now.AddDays(-3).ToLongDateString());

			Console.WriteLine("The current month is " + now.Month);

			// DateTime myBirthDay = new DateTime(2009, 6, 15);
			DateTime myBirthDay = DateTime.Parse("15 6 2009");
			Console.WriteLine("My birthday is " + myBirthDay.ToLongDateString());
			TimeSpan myAge = DateTime.Now - myBirthDay;
			Console.Write(String.Format("I have been alive for {0} days. ", myAge.Days));
			Console.Write("That is {0:N} hours and {1:N} seconds", Math.Round(myAge.TotalHours), 
																   Math.Round(myAge.TotalSeconds));


			Console.ReadLine();
		}
	}
}