using System;
// Class program.
// I only put a comment on the default program and put it at the bottom.
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = DateTime.Parse("03 Nov 2022"), Minutes = 30, Distance = 4.8 },
            new Cycling { Date = DateTime.Parse("04 Nov 2022"), Minutes = 45, Speed = 20 },
            new Swimming { Date = DateTime.Parse("05 Nov 2022"), Minutes = 60, Laps = 30 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation4 World!");
//     }
// }