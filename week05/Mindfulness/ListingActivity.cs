using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things by listing as many as you can.")
    {
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("You have 5 seconds to think...");
        Countdown(5);

        List<string> responses = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("\nStart listing items (Press enter after each):");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    responses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}
