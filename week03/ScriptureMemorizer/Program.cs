using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want."
            )
        };

        Random random = new Random();

        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" &&
               !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                selectedScripture.HideRandomWords(3);
            }
        }

        Console.Clear();

        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}

/*
Creativity Added:
- Added multiple scriptures stored in a scripture library.
- Program randomly selects a scripture each time it runs.
- Program avoids rehiding already hidden words.
*/