using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    public void AddEntry(JournalEntry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.");
            return;
        }

        Console.WriteLine("\n Journal Entries");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_entries, options);

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(jsonString);
            }
            Console.WriteLine($"\nJournal successfully saved to {filename} using JSON format.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"\nError saving journal to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"\nError: The file {filename} does not exist.");
            return;
        }

        try
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<JournalEntry>>(jsonString);
            Console.WriteLine($"\nJournal successfully loaded from {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError loading journal from file: {ex.Message}");
        }
    }
}