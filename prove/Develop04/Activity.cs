// A static dictionnary has been added to exceed the requirement.
// This will keep a log of how many times each activity is performed.

using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string _name;  // Private class created.
    protected string _description;
    protected int _duration;
    protected static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    public Activity(string name, string description)  // Public class created.
    {
        _name = name;
        _description = description;
        if (!_activityLog.ContainsKey(_name))
        {
            _activityLog[_name] = 0;
        }
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}\nDescription: {_description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
        _activityLog[_name]++;
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();

    public static void DisplayActivityLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in _activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}