using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Basics in 10 Minutes", "Dev Academy", 600);
        Video video2 = new Video("Mechanical Keyboard Review", "Tech Zone", 480);
        Video video3 = new Video("How to Bake Homemade Bread", "Practical Kitchen", 900);

        video1.AddComment(new Comment("Carlos", "Great explanation, very straightforward!"));
        video1.AddComment(new Comment("Ana", "This helped me a lot with my exam."));
        video1.AddComment(new Comment("Pedro", "Could you make a video about OOP?"));

        video2.AddComment(new Comment("Lucas", "Are these switches really quiet?"));
        video2.AddComment(new Comment("Mariana", "Just bought one because of this review!"));
        video2.AddComment(new Comment("John", "A bit too expensive in my opinion."));

        video3.AddComment(new Comment("Beatriz", "My dough turned out great, thanks!"));
        video3.AddComment(new Comment("Gabriel", "What is the exact oven temperature?"));
        video3.AddComment(new Comment("Fernanda", "Wonderful recipe, subscribed!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        Console.WriteLine(" YOUTUBE VIDEO TRACKING SYSTEM ");

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }
            
        }
    }
}