using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public double Minutes { get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}

public class Running : Activity
{
    public double Distance { get; set; } // in km

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60;
    public override double GetPace() => Minutes / Distance;
}

public class Cycling : Activity
{
    public double Speed { get; set; } // in kph

    public override double GetDistance() => (Speed / 60) * Minutes;
    public override double GetSpeed() => Speed;
    public override double GetPace() => Minutes / GetDistance();
}

public class Swimming : Activity
{
    public int Laps { get; set; } // 1 lap = 50 meters

    public override double GetDistance() => Laps * 50.0 / 1000;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}