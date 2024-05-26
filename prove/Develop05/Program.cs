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





// //using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Console.WriteLine("Hello Develop05 World!");
// //     }
// // }

