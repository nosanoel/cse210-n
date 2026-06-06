using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    reflectingCount++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    Console.WriteLine($"\nBreathing completed: {breathingCount}");
                    Console.WriteLine($"Reflecting completed: {reflectingCount}");
                    Console.WriteLine($"Listing completed: {listingCount}");
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:
This program tracks how many times each activity
has been completed during the current session.
*/