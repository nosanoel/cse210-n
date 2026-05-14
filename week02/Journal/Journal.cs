using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Journal saved successfully.");
        Console.ResetColor();
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File not found.");
            Console.ResetColor();
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                string mood = parts[3];

                Entry entry = new Entry(date, prompt, response, mood);

                _entries.Add(entry);
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Journal loaded successfully.");
        Console.ResetColor();
    }
}