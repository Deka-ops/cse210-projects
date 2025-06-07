using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about it?",
        "What did you learn from this?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times you have shown strength and resilience.")
    {
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        ShowSpinner(4);

        int elapsed = 0;
        int duration = GetDuration();

        while (elapsed < duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
            elapsed += 5;
        }

        End();
    }
}
