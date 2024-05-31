using System;
// The default program was commented bellow.
// A new class has been created as "User.cs".
class Program
{
    static void Main()
    {
        User user = new User("Smith");  // Create a new User.
        GoalManager manager = new GoalManager(user);  // Pass the User to the GoalManager.

        // Create SimpleGoal.
        Goal simpleGoal = new SimpleGoal("Run a Marathon", "Run 42.195 kilometers", 1000);
        manager.CreateGoal(simpleGoal);

        // Create EternalGoal.
        Goal eternalGoal = new EternalGoal("Read a Book", "Read any book", 100);
        manager.CreateGoal(eternalGoal);

        // Create ChecklistGoal.
        Goal checklistGoal = new ChecklistGoal("Visit Paris", "Visit Paris 10 times", 50, 10, 500);
        manager.CreateGoal(checklistGoal);

        // Start the GoalManager.
        manager.Start();

        // Record events
        manager.RecordEvent("Run a Marathon");
        manager.RecordEvent("Read a Book");
        manager.RecordEvent("Visit Paris");

        // Display player info.
        manager.DisplayPlayerInfo();

        // List goal names.
        manager.ListGoalNames();

        // List goal details.
        manager.ListGoalDetails();

        // Save goals.
        manager.SaveGoals();

        // Load goals.
        manager.LoadGoals();
    }
}


public class QuestTracker
{
    private List<Goal> _goals;
    private int _totalScore;

    public QuestTracker()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        var goal = _goals.Find(g => g._shortName == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _totalScore += goal._points;
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.Name} - Status: {goal.GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void SaveProgress(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, _goals);
        }
    }

    public void LoadProgress(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            _goals = (List<Goal>)formatter.Deserialize(stream);
        }
    }
}



// // //using System;

// // // class Program
// // // {
// // //     static void Main(string[] args)
// // //     {
// // //         Console.WriteLine("Hello Develop05 World!");
// // //     }
// // // }



