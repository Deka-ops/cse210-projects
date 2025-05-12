
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int n))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (n == 0)
                break;

            numbers.Add(n);
        }

        // Ensure at least one number was entered
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered. Exiting program.");
            return;
        }

        // Core Requirements
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge: smallest positive number
        var positives = numbers.Where(x => x > 0);
        if (positives.Any())
        {
            int smallestPositive = positives.Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // Stretch Challenge: sorted list
        var sorted = numbers.OrderBy(x => x).ToList();
        Console.WriteLine("The sorted list is:");
        foreach (var num in sorted)
        {
            Console.WriteLine(num);
        }
    }
}
