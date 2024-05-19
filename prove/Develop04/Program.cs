// Class program has been modified.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Program!");
        Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity");
        Console.Write("Choose an activity (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        Activity activity = null;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectingActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        activity.Run();
        Activity.DisplayActivityLog();
    }
}
