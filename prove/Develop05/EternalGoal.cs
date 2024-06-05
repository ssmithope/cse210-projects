// Eternal goal class.
public class EternalGoal : Goal
{
    public EternalGoal(string name, int pointsPerRecord) : base(name, pointsPerRecord) {}

    public override void RecordProgress()
    {
        Console.WriteLine($"Goal '{_name}' recorded. Earned {_points} points.");
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} - Eternal Goal - Points per Record: {_points}");
    }
}