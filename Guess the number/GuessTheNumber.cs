using System;
using MoreTypeExtensions;

public class GuessTheNumber
{
	public static void Main()
	{
		Console.WriteLine("What game would would you like to play? Please enter the number or name");
		Console.WriteLine("1) Guess the number");
		Console.WriteLine("2) Higher or lower");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
		string response = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

		if (response.ContainsCaseInsensitive("1") || response.ContainsCaseInsensitive("Guess the number"))
			PlayGuessTheNumber();
		else if (response.ContainsCaseInsensitive("2") || response.ContainsCaseInsensitive("Higher or lower"))
			PlayHigherOrLower();
	}

    private static void PlayGuessTheNumber()
    {
		Console.WriteLine("You are playing Guess the number");
        Console.WriteLine("Choose a mode: easy, medium, or hard");
        string mode = Console.ReadLine();
        int maxNumber = 0;
        int maxGuesses = 0;
        int guess = -1;

        if (mode.ContainsCaseInsensitive("easy"))
        {
            maxNumber = 11;
            maxGuesses = 3;
        }
        else if (mode.ContainsCaseInsensitive("medium"))
        {
            maxNumber = 31;
            maxGuesses = 6;
        }
        else if (mode.ContainsCaseInsensitive("hard"))
        {
            maxNumber = 51;
            maxGuesses = 8;
        }

        while (true)
        {
            int timesGuessed = 0;
            Random random = new Random();
            int numberToGuess = random.Next(0, maxNumber);

            Console.WriteLine("Guess a number between 0 and " + (maxNumber - 1));

            while (true)
            {


                if (timesGuessed == maxGuesses)
                {
                    Console.WriteLine("You lost. The number was " + numberToGuess);
                    break;
                }
                else
                {
                    guess = int.Parse(Console.ReadLine());
                }
                if (guess == numberToGuess)
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
                timesGuessed++;
            }
        }
    }

    private static void PlayHigherOrLower()
	{
		Console.WriteLine("You are playing higher or lower");
		Console.WriteLine("Choose a mode: easy, medium, or hard");
		string mode = Console.ReadLine();
		int maxNumber = 0;
		int maxGuesses = 0;
		int guess = -1;

		if (mode.ContainsCaseInsensitive("easy"))
		{
			maxNumber = 11;
			maxGuesses = 3;
		}
		else if (mode.ContainsCaseInsensitive("medium"))
		{
			maxNumber = 31;
			maxGuesses = 6;
		}
		else if (mode.ContainsCaseInsensitive("hard"))
		{
			maxNumber = 51;
			maxGuesses = 8;
		}

		while (true)
		{
			int timesGuessed = 0;
			Random random = new Random();
			int numberToGuess = random.Next(0, maxNumber);

			Console.WriteLine("Guess a number between 0 and " + (maxNumber - 1));

			while (true)
			{


				if (timesGuessed == maxGuesses)
				{
					Console.WriteLine("You lost. The number was " + numberToGuess);
					break;
				}
				else
					guess = int.Parse(Console.ReadLine());

				if (guess == numberToGuess)
				{
					Console.WriteLine("You guessed the number!");
					break;
				}
				else if (guess < numberToGuess)
					Console.WriteLine("Too low");
				else if (guess > numberToGuess)
					Console.WriteLine("Too high");

				timesGuessed++;
			}
		}
	}
}