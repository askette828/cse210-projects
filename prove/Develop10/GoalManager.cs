using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        int index = 1;

        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetStatus()} {goal.Name} - {goal.Description}");
            index++;
        }
        Console.WriteLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the goal number:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("> ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int points = _goals[choice].RecordEvent();
            _score += points;

            CheckLevelUp();

            Console.WriteLine($"You earned {points} points!");
            Console.WriteLine($"Total Score: {_score}");
        }
    }

    private void CheckLevelUp()
    {
        int required = _level * 500;

        if (_score >= required)
        {
            _level++;
            Console.WriteLine($"\n🎉 LEVEL UP! You reached Level {_level}!\n");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"\nScore: {_score}   |   Level: {_level}\n");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            sw.WriteLine(_level);

            foreach (var g in _goals)
            {
                sw.WriteLine(g.ToCSV());
            }
        }

        Console.WriteLine("Goals saved!\n");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.\n");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                AddGoal(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]),
                    bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                AddGoal(new ChecklistGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[5]), int.Parse(parts[6]),
                    int.Parse(parts[4])
                ));
            }
        }

        Console.WriteLine("Goals loaded!\n");
    }
}
