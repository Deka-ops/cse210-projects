using System;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Bake a Cake", "BakerJane", 300);
        Video video2 = new Video("Yoga for Beginners", "HealthyLife", 600);
        Video video3 = new Video("Learning C#", "CodeMaster", 900);

        // Add comments
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "I love baking, thanks!"));

        video2.AddComment(new Comment("Cara", "This helped me relax."));
        video2.AddComment(new Comment("Dan", "Very easy to follow."));

        video3.AddComment(new Comment("Eve", "C# is awesome!"));
        video3.AddComment(new Comment("Frank", "More tutorials, please!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video info and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
