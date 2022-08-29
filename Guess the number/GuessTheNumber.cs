using MoreTypeExtensions;

// ReSharper disable once CheckNamespace
namespace GuessTheNumber
	// ReSharper disable once ArrangeNamespaceBody
{
	// ReSharper disable once ClassNeverInstantiated.Global
	public class GuessTheNumber
	{
		private static int maxNumber;
		private static int maxGuesses;
		private static int guess;

		private static void Main()
		{
			Menu();
		}

		private static void Menu()
		{
			Console.WriteLine("What game would would you like to play?");
			Console.WriteLine("1) Guess the number");
			Console.WriteLine("2) Higher or lower");
			string? gameMode;
			do
			{
				do
				{
					Console.WriteLine("Please enter the number or name");
					gameMode = Console.ReadLine();
				} while (gameMode == "");

				SetGame(gameMode);
			} while (!SetGame(gameMode));

			Console.Clear();
		}

		private static bool SetGame(string? response)
		{
#pragma warning disable CS8604
			if (response.IgnoreCaseContains("1") || response.IgnoreCaseContains("Guess the number"))
#pragma warning restore CS8604
			{
				PlayGuessTheNumber();
				return true;
			}
			// ReSharper disable once InvertIf
			if (response.IgnoreCaseContains("2") || response.IgnoreCaseContains("Higher or lower"))
			{
				PlayHigherOrLower();
				return true;
			}

			return false;
		}

		private static void PlayGuessTheNumber()
		{
			Console.WriteLine("You are playing Guess the number");
			SetMode();

			while (true)
			{
				int timesGuessed = 0;
				int numberToGuess = GenerateRandomNumber();

				Console.WriteLine("Guess a number between 0 and " + (maxNumber - 1));

				while (true)
				{


					if (timesGuessed == maxGuesses)
					{
						Console.WriteLine("You lost. The number was " + numberToGuess);
						break;
					}
#pragma warning disable CS8604
						guess = int.Parse(Console.ReadLine());
#pragma warning restore CS8604
					if (guess == numberToGuess)
					{
						Console.WriteLine("You guessed the number!");
						break;
					}

					timesGuessed++;
				}
			}
			// ReSharper disable once FunctionNeverReturns
		}

		private static void PlayHigherOrLower()
		{
			Console.WriteLine("You are playing higher or lower");
			SetMode();

			while (true)
			{
				int timesGuessed = 0;
				int numberToGuess = GenerateRandomNumber();

				Console.WriteLine("Guess a number between 0 and " + (maxNumber - 1));

				while (true)
				{
					if (timesGuessed == maxGuesses)
					{
						Console.WriteLine("You lost. The number was " + numberToGuess);
						break;
					}
#pragma warning disable CS8604
					guess = int.Parse(Console.ReadLine());
#pragma warning restore CS8604

					if (guess == numberToGuess)
					{
						Console.WriteLine("You guessed the number!");
						break;
					}

					if (guess < numberToGuess)
						Console.WriteLine("Too low");
					else if (guess > numberToGuess)
						Console.WriteLine("Too high");

					timesGuessed++;
				}
			}
			// ReSharper disable once FunctionNeverReturns
		}

		private static int GenerateRandomNumber()
		{
			Random random = new();
			int numberToGuess = random.Next(0, maxNumber);
			return numberToGuess;
		}

		private static void SetMode()
		{
			Console.WriteLine("Choose a mode: easy, medium, or hard");
			string? mode;
			int i = 0;
			do
			{
				if (i > 0) Console.WriteLine("Can you please enter the mode again?");

				mode = Console.ReadLine();
				i++;
			} while (!CheckEnteredModeIsCorrect(mode));

			maxNumber = 0;
			maxGuesses = 0;
			guess = -1;

#pragma warning disable CS8604
			if (mode.IgnoreCaseContains("easy"))
#pragma warning restore CS8604
			{
				maxNumber = 11;
				maxGuesses = 3;
			}
			else if (mode.IgnoreCaseContains("medium"))
			{
				maxNumber = 31;
				maxGuesses = 6;
			}
			else if (mode.IgnoreCaseContains("hard"))
			{
				maxNumber = 51;
				maxGuesses = 8;
			}
		}

		private static bool CheckEnteredModeIsCorrect(string? mode)
		{
			if (mode == "")
				return false;
			// ReSharper disable once ConvertIfStatementToReturnStatement
#pragma warning disable CS8604
			if (!mode.IgnoreCaseContains("easy") && !mode.IgnoreCaseContains("medium") && !mode.IgnoreCaseContains("hard"))
#pragma warning restore CS8604
				return false;

			return true;
		}
	}
}