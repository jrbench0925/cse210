using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            int guess = -1;
            Random firstNumber = new Random();
            int number = firstNumber.Next (1, 1000);
            int guessCount = 0;

            while (guess != number )
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                    if (guessCount > 1)
                    {
                        Console.WriteLine($"It took you {guessCount} guesses");
                    }
                    else
                    {
                        Console.WriteLine($"It only took you {guessCount} guess!");
                    }
                }
            }
            Console.Write("Would you like to play again? ");
            keepPlaying = Console.ReadLine().ToLower();
        }
    }
}