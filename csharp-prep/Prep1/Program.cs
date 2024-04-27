using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the first and last name from the user.
        Console.Write("Whats is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
       
        
    }
}