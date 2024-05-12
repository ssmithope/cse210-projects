// I put a comment to the default program which is "Hello Develop03 World!".
using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        
       var reference1 = new Reference("John", 3, 16);
        var scriptureText1 = "For God so loved the world...";
        var scripture1 = new Scripture(reference1, scriptureText1);

        var reference2 = new Reference("Proverbs", 3, 5);
        var scriptureText2 = "Trust in the LORD with all your heart...";
        var scripture2 = new Scripture(reference2, scriptureText2);

        var scriptures = new List<Scripture> { scripture1, scripture2 };

        foreach (var scripture in scriptures)
        {
            while (!scripture.IsCompletelyHidden())
            {
                scripture.GetDisplayText();
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);
                Console.Clear();
            }
        }

        Console.WriteLine("All words are hidden. Program ended.");
    }
 
}
