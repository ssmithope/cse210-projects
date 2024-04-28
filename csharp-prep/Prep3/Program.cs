using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        // I've tried the dowhile loop.
        // Get a majic number from the user.
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 20);

        int guess = -1;

        do
        {
            Console.Write("What is your magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
        } while (magic_number != guess);
        Console.WriteLine("You guessed it!");
        
    }
}