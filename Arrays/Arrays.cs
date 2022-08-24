using System;
using MoreTypeExtensions;

namespace Arrays
{
	class Arrays
	{
		static void Main(string[] args)
		{
			// Here is one way to create an array.
			int[] numbers = new int[5]; // The 5 stands for the maximum amount of things in the array.
			// You can access a specific value from an array using its index.
			numbers[0] = 8;
			numbers[1] = 64;
			numbers[2] = 21;
			numbers[3] = 12;
			numbers[4] = 2;

            // Here we don't specify how many numbers you want.
			// Instead, the compiler just uses how many numbers you typed.
			// It also looks alot cleaner.
            int[] numbers2 = new int[] {8, 64, 21, 12, 2};

			// Here is the same concept with strings
			string[] names = new string[] {"Emily", "David", "Edward", "Ryan", "Ronald"};

			// This for loop prints out all the vaules in "names"
			for (int name = 0; name < names.Length; name++)
			{
				Console.WriteLine(names[name]);
			}

			// A foreach does the same thing as the above for loop
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine(("Soumil32").ReverseString());
        }

		
    }
}