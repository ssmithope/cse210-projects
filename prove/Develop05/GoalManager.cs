using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Goal Manager class.
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    // Method to add a goal to the list.
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to record an event by goal name.
    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _totalPoints += goal.Points;
                break;
            }
        }
    }

    // Method to display all goals.
    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    // Method to display the total score.
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalPoints}");
    }

    // Method to save the progress to a file using JSON serialization.
    public void SaveProgress(string filePath)
    {
        string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    // Method to load the progress from a file using JSON deserialization.
    public static GoalManager LoadProgress(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<GoalManager>(jsonString);
    }
}