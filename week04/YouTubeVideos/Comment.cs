using System;

using System;

public class Comment
{
    // Properties to store comment data
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to quickly instantiate a new comment
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}