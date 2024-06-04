// Simple goal class.
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _points += 1000; // Assuming completing a simple goal gives 1000 points
    }

    public override string Display()
    {
        return _isComplete ? $"[X] {_name} - {_points} points" : $"[ ] {_name} - {_points} points";
    }
}



