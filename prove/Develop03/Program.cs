// I still keep the default program at the bottom by a comment
// I wanted to exceed the requirement but I failed multiple times.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scripture.Display();

        while (true)
        {
            Console.WriteLine("\nPress enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();
            scripture.Display();
        }
        
    }

}    
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
//     }
// }