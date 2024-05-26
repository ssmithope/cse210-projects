public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int pts) : base(name, desc, pts)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"EternalGoal: {GetName()}, Description: {GetDescription()}, Points: {GetPoints()}";
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}
