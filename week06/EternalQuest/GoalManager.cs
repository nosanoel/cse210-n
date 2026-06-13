
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public string GetLevel()
    {
        if (_score >= 10000)
            return "Eternal Hero";

        if (_score >= 5000)
            return "Champion";

        if (_score >= 3000)
            return "Knight";

        if (_score >= 1000)
            return "Adventurer";

        return "Novice";
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus));
                break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine();

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }

    public void RecordGoalEvent()
    {
        DisplayGoals();

        Console.Write("Goal Number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();

            _score += pointsEarned;

            Console.WriteLine($"You earned {pointsEarned} points!");
            Console.WriteLine($"Total score: {_score}");
        }

        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
            return;

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(
                        new SimpleGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            bool.Parse(parts[4])));
                    break;

                case "EternalGoal":
                    _goals.Add(
                        new EternalGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(
                        new ChecklistGoal(
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            int.Parse(parts[4]),
                            int.Parse(parts[5]),
                            int.Parse(parts[6])));
                    break;
            }
        }
    }
}

