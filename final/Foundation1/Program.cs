using System;
using System.Collections.Generic;
using YouTubeTracker;

namespace YouTubeTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("C# Basics Tutorial", "John Doe", 600);
            Video video2 = new Video("Understanding OOP", "Sarah Smith", 850);
            Video video3 = new Video("LINQ in 10 Minutes", "Code Master", 720);

            
            video1.AddComment(new Comment("Alice", "Great explanation!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Clear and easy to follow."));

 
            video2.AddComment(new Comment("David", "OOP finally makes sense now."));
            video2.AddComment(new Comment("Emma", "Loved the examples."));
            video2.AddComment(new Comment("Frank", "Thanks for the tutorial!"));

            video3.AddComment(new Comment("Grace", "LINQ is awesome!"));
            video3.AddComment(new Comment("Henry", "Short and powerful."));
            video3.AddComment(new Comment("Ivy", "This helped me a lot."));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
                }

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
