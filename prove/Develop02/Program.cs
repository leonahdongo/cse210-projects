

using System.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;


class Journal
{
    static void Main(string[] args);
    private List<Entry> entries = new List<Entry>()
    {
        

    };
    private List<string> prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public void WriteNewEntry()
    {
        // Select a random prompt
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);
        string selectedPrompt = prompts[promptIndex];
        // Get the user's response
        Console.WriteLine("New entry prompt: " + selectedPrompt);
        string response = Console.ReadLine();
        // Create a new entry and add it to the list
        Entry newEntry = new Entry(selectedPrompt, response, DateTime.Now);
        entries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }
    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter a filename to save the journal to:");
        string filename = Console.ReadLine();
        

        using (StreamWriter outputFile = new StreamWriter(filename))
        

        foreach (Entry entry in entries)
        {
            outputFile.WriteLine();
                outputFile.WriteLine("Date: " + entry.Date);
            outputFile.WriteLine("Prompt: " + entry.Prompt);
            outputFile.WriteLine("Response: " + entry.Response);
            outputFile.WriteLine();
        }
    }
    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            

        }
    }

    public void ShowMenu()
    {
        Console.WriteLine("Hello Develop02 World!");
        string input = "";
        while (input != "5")
        {
            

            Console.WriteLine("Journal Menu App");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.WriteLine("Please select an option:");
            input = Console.ReadLine();
            if (input == "1")
            {
                WriteNewEntry();
            }
            else if (input == "2")
            {
                DisplayJournal();
            }
            else if (input == "3")
            {
                SaveJournalToFile();
            }
            else if (input == "4")
            {
                LoadJournalFromFile();
            }
            else if (input == "5")
            {
                Console.WriteLine ("Thank you for using this journal.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid option! Please try again.");
            }
        }
    }
}
class Entry
{
    public Entry(string prompt, string response, DateTime date)
{
    this.Prompt = prompt;
    this.Response = response;
    this.Date = date.ToString();
}
    public string Prompt;
    public string Response;
    public string Date;
}
class Program
{
public static void Main()
{
    Journal journal = new Journal();
    journal.ShowMenu();
}
}

                    