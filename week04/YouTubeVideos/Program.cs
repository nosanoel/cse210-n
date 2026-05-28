

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# Basics", "CodeMaster", 600);
        Video video2 = new Video("Gaming Highlights", "ProGamer", 1200);
        Video video3 = new Video("Cooking Pasta", "Chef Anna", 900);
        Video video4 = new Video("Travel Vlog Paris", "WanderWorld", 1500);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for explaining clearly."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Awesome gameplay!"));
        video2.AddComment(new Comment("Emma", "That ending was crazy."));
        video2.AddComment(new Comment("Frank", "Can't wait for more videos."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This recipe looks delicious."));
        video3.AddComment(new Comment("Henry", "I tried it and loved it."));
        video3.AddComment(new Comment("Isabella", "Easy to follow instructions."));

        // Add comments to video4
        video4.AddComment(new Comment("Jack", "Paris is beautiful."));
        video4.AddComment(new Comment("Karen", "Loved the cinematography."));
        video4.AddComment(new Comment("Leo", "Adding Paris to my bucket list!"));

        // Store videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}"
                );
            }

            Console.WriteLine();
        }
    }
}

