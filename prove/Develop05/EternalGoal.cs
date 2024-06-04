// Eternal goal class.
public class EternalGoal : Goal
{
    public EternalGoal(string name)
    {
        _name = name;
        _points = 0;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _points += 100; // Each event adds 100 points.
    }

    public override string Display()
    {
        return $"[~] {_name} - {_points} points";
    }
}