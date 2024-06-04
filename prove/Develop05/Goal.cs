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

    public string Name { get { return _name; } set { _name = value; } }
    public int Points { get { return _points; } set { _points = value; } }
    public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }

    public abstract void RecordEvent();
    public abstract string Display();
}