using System;
public class Program
{
    public static void Main()
    {
        while(true)
        {
            Random random = new Random();
            int numberToGuess = random.Next(0, 11);

            int guess = int.Parse(Console.ReadLine());
            if (guess == numberToGuess)
            {
                Console.WriteLine("You guessed the number!");
            }
            else
            {
                Console.WriteLine("You didn't guess the number. It was " + numberToGuess);
            }
        }
    }
}