using System;

public class Comment
{
    private string commenterName;
    private string commentText;

    public Comment(string commenterName, string commentText)
    {
        this.commenterName = commenterName;
        this.commentText = commentText;
    }

    public string getCommenterName()
    {
        return commenterName;
    }

    public string getCommentText()
    {
        return commentText;
    }
}
