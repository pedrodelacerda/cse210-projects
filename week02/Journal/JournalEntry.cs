using System;

public class JournalEntry
{
    public string _date {get; set;}
    public string _prompt {get; set;}
    public string _response {get; set;}

    public JournalEntry(){}
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine(new string('-', 50));
    }
}

