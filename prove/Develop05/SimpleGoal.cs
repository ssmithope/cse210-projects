// Simple goal class.
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordProgress()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed!");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} - Complete: {(_isComplete ? "[X]" : "[ ]")} - Points: {_points}");
    }
}
