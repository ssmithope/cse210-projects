using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int pts)
    {
        _shortName = name;
        _description = desc;
        _points = pts;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();
}