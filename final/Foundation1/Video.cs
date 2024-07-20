using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public string getTitle()
    {
        return title;
    }

    public string getAuthor()
    {
        return author;
    }

    public int getLength()
    {
        return length;
    }

    public void addComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int getCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> getComments()
    {
        return comments;
    }
}
