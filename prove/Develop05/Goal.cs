using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Goal class.
public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    protected Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordProgress();
    public abstract void Display();
    public string Name => _name;
    public int Points => _points;
    public bool IsComplete => _isComplete;
}