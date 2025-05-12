using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number, ...
        // console.Write("What is the magic number?" );
        // int magicNumber = int.Parse(console.ReadLine());

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {

            // For Part 3, where we use a random number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // We could also use a do-while loop here...
            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                string input = (Console.ReadLine());

                if (int.TryParse(input, out guess))
                {
                    guessCount++;

                    if (magicNumber > guess)
                    {
                        Console.WriteLine("Higher!");
                    }
                    else if (magicNumber < guess)
                    {
                        Console.WriteLine("Lower!");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {guessCount} guess!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                    }

                    // Ask the user if they want to play again
                    Console.Write("Do you want to play again? (yes/no): ");
                    playAgain = Console.ReadLine();
                    Console.WriteLine(); // Add space before the next game starts
                }

                Console.WriteLine("Thanks for playing! Goodbye!");
            }
        }
    }

}
