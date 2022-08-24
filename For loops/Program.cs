using System;

namespace ForLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0 /*Initialize a variable*/; i < 10 /* Add a condition*/; i++ /* Change the value*/)
			{
				if (i == 7) // Check if i is equals to 7
				{
					Console.WriteLine("I found seven");
					break;
				} //If it isn't add 1 to i and run it again if it is still under 10
			}
		}
	}
}