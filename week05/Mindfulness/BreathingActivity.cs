using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public override void Run()
    {
        Start();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            Console.WriteLine("Now breathe out...");
            Countdown(6);
            elapsed += 10;
        }

        End();
    }
}
