using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    
    // List to store all comments associated with this video
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Method required by specification: returns total count of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Helper method to add a comment to the list
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}