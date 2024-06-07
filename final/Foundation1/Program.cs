using System;
using System.Collections.Generic;

public class Program 
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User 1", "So funny! Great video!");
        video1.AddComment("User 2", "Learned so much!");

        Video video2 = new Video("Video 2", "Author 2", 120);
        video2.AddComment("User 3", "Amazing video!");
        video2.AddComment("User 4", "Made me laugh so hard!");

        Video video3 = new Video("Video 3", "Author 3", 120);
        video3.AddComment("User 5", "Aww this is so sweet!");
        video3.AddComment("User 6", "Makes me want to cry happy tears!");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: " + video._title);
            Console.WriteLine($"Author: " + video._author);
            Console.WriteLine($"Length (seconds): " + video._length);
            Console.WriteLine($"Number of Comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(" - " + comment._name + ": " + comment._text);
            }
            Console.WriteLine();
        }
    }
} 