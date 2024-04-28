using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        // Get the numbers from the user
        // until the user enter 0 to finish the list and compute
        // the total of numbers entering.

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int user_number = -1;
        while (user_number != 0)
        {
            Console.Write("Enter a number: ");
            string user_choice = Console.ReadLine();
            user_number = int.Parse(user_choice);


            if (user_number != 0)
            {
                numbers.Add(user_number);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

         int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }

        Console.WriteLine($"The maximum number is: {max}");
    }
}