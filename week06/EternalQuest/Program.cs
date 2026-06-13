
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        // Creativity:
        // Added a level system that awards titles based on score.
        // Novice, Adventurer, Knight, Champion, Eternal Hero.

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine($"Level: {manager.GetLevel()}");
            Console.WriteLine();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.RecordGoalEvent();
                    break;

                case "4":
                    manager.SaveGoals();
                    break;

                case "5":
                    manager.LoadGoals();
                    break;

                case "6":
                    return;
            }
        }
    }
}

