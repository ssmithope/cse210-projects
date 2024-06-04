using System;

// Program class.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Add goals.
        goalManager.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures"));
        goalManager.AddGoal(new ChecklistGoal("Attend Temple", 10, 500));

        // Record events.
        goalManager.RecordEvent("Run a Marathon");
        goalManager.RecordEvent("Read Scriptures");
        goalManager.RecordEvent("Attend Temple");

        // Display goals and score.
        goalManager.DisplayGoals();
        goalManager.DisplayScore();

        // Save progress.
        goalManager.SaveProgress("goalManager.dat");

        // Load progress.
        GoalManager loadedGoalManager = GoalManager.LoadProgress("goalManager.dat");
        loadedGoalManager.DisplayGoals();
        loadedGoalManager.DisplayScore();
    }
}



// // // //using System;

// // // // class Program
// // // // {
// // // //     static void Main(string[] args)
// // // //     {
// // // //         Console.WriteLine("Hello Develop05 World!");
// // // //     }
// // // // }



