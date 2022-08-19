using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose a mode: easy, medium, or hard");
        string mode = Console.ReadLine();
        int maxNumber = 0;
        
        if (mode == "easy")
        {
            maxNumber = 11;
        }else if (mode == "medium")
        {
            maxNumber = 31;
        }
        else if (mode == "hard")
        {
            maxNumber = 51;
        }

        while (true)
        {
            Random random = new Random();
            int numberToGuess = random.Next(0, maxNumber);

            Console.WriteLine("Guess a number between 0 and " + maxNumber);
            int guess = int.Parse(Console.ReadLine());

            while (guess != numberToGuess)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == numberToGuess)
                {
                    Console.WriteLine("You guessed the number!");
                }
            }
            
        }
    }
}