using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 500);
        Video video3 = new Video("Video 3", "Author 3", 250);
        Video video4 = new Video("Video 4", "Author 4", 400);

        // Add comments to videos
        video1.addComment(new Comment("Commenter 1", "Great video!"));
        video1.addComment(new Comment("Commenter 2", "Very informative."));
        video1.addComment(new Comment("Commenter 3", "Thanks for sharing!"));

        video2.addComment(new Comment("Commenter 4", "Awesome content!"));
        video2.addComment(new Comment("Commenter 5", "Loved it."));
        video2.addComment(new Comment("Commenter 6", "Keep it up!"));

        video3.addComment(new Comment("Commenter 7", "Nice video!"));
        video3.addComment(new Comment("Commenter 8", "Well done."));
        video3.addComment(new Comment("Commenter 9", "Very helpful."));

        video4.addComment(new Comment("Commenter 10", "Fantastic!"));
        video4.addComment(new Comment("Commenter 11", "Really good."));
        video4.addComment(new Comment("Commenter 12", "I enjoyed this."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.getTitle()}");
            Console.WriteLine($"Author: {video.getAuthor()}");
            Console.WriteLine($"Length: {video.getLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.getCommentCount()}");

            foreach (Comment comment in video.getComments())
            {
                Console.WriteLine($"  {comment.getCommenterName()}: {comment.getCommentText()}");
            }
            Console.WriteLine();
        }
    }
}
