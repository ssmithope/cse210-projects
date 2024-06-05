// Check list goal class.
public class ChecklistGoal : Goal
{
    private int _progress;
    private readonly int _goalCount;
    private readonly int _bonusPoints;

    public ChecklistGoal(string name, int pointsPerRecord, int goalCount, int bonusPoints) : base(name, pointsPerRecord)
    {
        _goalCount = goalCount;
        _bonusPoints = bonusPoints;
        _progress = 0;
    }

    public override void RecordProgress()
    {
        _progress++;
        if (_progress >= _goalCount && !_isComplete)
        {
            _isComplete = true;
            _points += _bonusPoints;
            Console.WriteLine($"Goal '{_name}' completed with bonus!");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' progress recorded. {_progress}/{_goalCount} times completed.");
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} - Completed {_progress}/{_goalCount} times - Points per Record: {_points} - Bonus: {_bonusPoints}");
    }
}