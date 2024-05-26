public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int pts) : base(name, desc, pts)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"SimpleGoal: {GetName()}, Description: {GetDescription()}, Points: {GetPoints()}, Completed: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}
