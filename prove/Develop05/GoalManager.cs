using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Manager goal class.
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.Name}' added.");
    }

    public void RecordGoal(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase) && !goal.IsComplete)
            {
                goal.RecordProgress();
                _totalPoints += goal.Points;
                Console.WriteLine($"Progress recorded for {goalName}. Total points: {_totalPoints}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            goal.Display();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveProgress(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(this, options);
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine("Progress saved successfully.");
    }

    public static GoalManager LoadProgress(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<GoalManager>(jsonString);
    }
}