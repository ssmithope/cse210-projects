// Checklist goal class.
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int targetCount, int bonusPoints)
    {
        _name = name;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
        _points = 0;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        _points += 50; // Assuming each event adds 50 points.
        if (_currentCount == _targetCount)
        {
            _points += _bonusPoints;
            _isComplete = true;
        }
    }

    public override string Display()
    {
        return _isComplete ? $"[X] {_name} - Completed {_currentCount}/{_targetCount} times" : $"[ ] {_name} - Completed {_currentCount}/{_targetCount} times";
    }
}