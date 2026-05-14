using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine("--------------------------------\n");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}";
    }
}