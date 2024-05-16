using System;
using System.Collections.Generic;
using System.IO;

// Calling the public class function.
public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "What did I do after wake up from the bed each morning?",
        "What difference I had noticed when I pray often?",
        "How could I overcome challenges and temptations?",
        "How did I see the hand of the Lord in my life when I keep His commandments?",
        "What was the marvelous experience I got through the guidance of the Spirit?",
        "If I have to pray for someone, who should I consider?"
    };

// Calling the random function.
    public void WriteEntry()
    {
        Random ran = new Random();
        string prompt = prompts[ran.Next(prompts.Count)];
        Console.WriteLine($"Today's prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry
        {
            PromptText = prompt,
            EntryText = response,
            Date = DateTime.Now
        });
    }

// Calling the display, the save and the load functions,
// so the user can chose an option.
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.PromptText}, Response: {entry.EntryText}");
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                file.WriteLine($"{entry.Date} | {entry.PromptText} | {entry.EntryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        entries.Clear();
        using (StreamReader file = new StreamReader(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                entries.Add(new Entry
                {
                    Date = DateTime.Parse(parts[0]),
                    PromptText = parts[1].Trim(),
                    EntryText = parts[2].Trim()
                });
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
