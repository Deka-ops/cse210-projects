using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a new magic number each round
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // Main guessing loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher!");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower!");
                    }
                    else
                    {
                        // Correct guess—pluralize “guess” appropriately
                        string plural = guessCount == 1 ? "guess" : "guesses";
                        Console.WriteLine($"You guessed it in {guessCount} {plural}!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Ask to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().Trim();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
