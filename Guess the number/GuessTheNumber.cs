using System;
public class GuessTheNumber
{
public static bool ContainsCaseInsensitive(this string source, string substring)
    {
        return source?.IndexOf(substring, StringComparison.OrdinalIgnoreCase) > -1;
    }

    public static void Main()
    {
        Console.WriteLine("Choose a mode: easy, medium, or hard");
        string mode = Console.ReadLine();
        int maxNumber = 0;
        int maxGuesses = 0;
        int guess = -1;
        bool exitLoop = false;

        if (mode.ContainsCaseInsensitive("easy")))
        {
            maxNumber = 11;
            maxGuesses = 3;
        }
        else if (mode.ContainsCaseInsensitive("medium")))
        {
            maxNumber = 31;
            maxGuesses = 6;
        }
        else if (mode.ContainsCaseInsensitive("hard")))
        {
            maxNumber = 51;
            maxGuesses = 8;
        }

        while (true)
        {
            exitLoop = false;
            int timesGuessed = 0;
            Random random = new Random();
            int numberToGuess = random.Next(0, maxNumber);

            Console.WriteLine("Guess a number between 0 and " + (maxNumber - 1));
            
            while(!exitLoop)
            {
                

                if (timesGuessed == maxGuesses)
                {
                    Console.WriteLine("You lost. The number was " + numberToGuess);
                    exitLoop = true;
                }else
{
    guess = int.Parse(Console.ReadLine());
} 
                if (guess == numberToGuess)
                {
                    Console.WriteLine("You guessed the number!");
                    exitLoop = true;
                } 
                timesGuessed++;
            }
        }
    }
}
