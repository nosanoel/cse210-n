using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity Feature:
        // Added mood tracking to journal entries so users can
        // record how they felt each day along with their response.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.ResetColor();

            Console.Write("Select an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("Mood today: ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, response, mood);

                journal.AddEntry(entry);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Entry added successfully.");
                Console.ResetColor();
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}