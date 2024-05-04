using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // Add more prompts here
    };

    public void WriteEntry()
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine($"Today's prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        });
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
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
                file.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Response}");
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
                entries.Add(new JournalEntry
                {
                    Date = DateTime.Parse(parts[0]),
                    Prompt = parts[1].Trim(),
                    Response = parts[2].Trim()
                });
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
