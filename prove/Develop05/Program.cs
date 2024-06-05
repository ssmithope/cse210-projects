// Program class.
// I put a new class called "Challe"

class Program
{
    static void Main()
    {
        var goalManager = new GoalManager();

        // Add a challenge goal to the manager
        goalManager.AddGoal(new ChallengeGoal("Marathon Prep", 100, 4, 500));

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Goal Program");
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record a goal");
            Console.WriteLine("3. Display all goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save progress");
            Console.WriteLine("6. Load progress");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddNewGoal(goalManager);
                    break;
                case "2":
                    RecordAGoal(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    SaveProgress(goalManager);
                    break;
                case "6":
                    LoadProgress(goalManager);
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    // AddNewGoal, RecordAGoal, SaveProgress, LoadProgress.
    static void AddNewGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine();

        switch (type.ToLower())
        {
            case "simple":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "eternal":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "checklist":
                Console.Write("Enter number of times to complete the goal: ");
                int goalCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, goalCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordAGoal(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal to record: ");
        string goalName = Console.ReadLine();
        goalManager.RecordGoal(goalName);
    }

    static void SaveProgress(GoalManager goalManager)
    {
        Console.Write("Enter the file path to save progress: ");
        string filePath = Console.ReadLine();
        goalManager.SaveProgress(filePath);
    }

    static void LoadProgress(GoalManager goalManager)
    {
        Console.Write("Enter the file path to load progress: ");
        string filePath = Console.ReadLine();
        goalManager = GoalManager.LoadProgress(filePath);
        Console.WriteLine("Progress loaded successfully.");
    }
}
