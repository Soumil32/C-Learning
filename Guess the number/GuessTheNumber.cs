using System;
using MoreTypeExtensions;

public class GuessTheNumber
{
	static int maxNumber = 0;
	static int maxGuesses = 0;
	static int guess = -1;
	private static void Main()
	{
		Menu();
	}

	private static void Menu()
	{
		Console.WriteLine("What game would would you like to play? Please enter the number or name");
		Console.WriteLine("1) Guess the number");
		Console.WriteLine("2) Higher or lower");
		string response = Console.ReadLine();

		if (response.ContainsCaseInsensitive("1") || response.ContainsCaseInsensitive("Guess the number"))
			PlayGuessTheNumber();
		else if (response.ContainsCaseInsensitive("2") || response.ContainsCaseInsensitive("Higher or lower"))
			PlayHigherOrLower();
	}

	private static void PlayGuessTheNumber()
	{
		Console.WriteLine("You are playing Guess the number");
		GetMode();

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
		GetMode();

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

	private static void GetMode()
	{
        Console.WriteLine("Choose a mode: easy, medium, or hard");
        string mode = Console.ReadLine();
		maxNumber = 0;
		maxGuesses = 0;
		guess = -1;

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
	}
}