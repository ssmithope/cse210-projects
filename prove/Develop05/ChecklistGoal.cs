public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int pts, int target, int bonusPts) : base(name, desc, pts)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonusPts;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _amountCompleted = _target; // Ensure we don't exceed the target.
            return GetPoints() + _bonus;  // Return points plus bonus when goal is completed.
        }
        return GetPoints();  // Return points every time event is recorded.
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"ChecklistGoal: {GetName()}, Description: {GetDescription()}, Points: {GetPoints()}, Progress: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}
