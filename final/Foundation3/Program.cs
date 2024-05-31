using System; 
public class Program
{
    public static void Main(string[] args)
    {
        var events = new List<Event>
        {
            new Lecture("Lecture 1", "Description 1", DateTime.Now, TimeSpan.FromHours(1), new Address("Street 1", "City 1", "State 1", "Country 1"), "Speaker 1", 100),
            new Reception("Reception 1", "Description 2", DateTime.Now, TimeSpan.FromHours(2), new Address("Street 2", "City 2", "State 2", "Country 2"), "rsvp@example.com"),
            new OutdoorGathering("Outdoor Gathering 1", "Description 3", DateTime.Now, TimeSpan.FromHours(3), new Address("Street 3", "City 3", "State 3", "Country 3"), "Sunny")
        };

        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}








// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation3 World!");
//     }
// }