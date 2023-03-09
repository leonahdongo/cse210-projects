using System;
using System.Threading;
using MindfulnessApp;

// The entry point for the program.
// Displays a menu of activities and prompts the user to choose one.
// Then, prompts the user to enter a duration and begins the selected activity for that duration.
// The program loops until the user chooses to quit.
Console.WriteLine("Welcome to Mindfulness App!");

while (true)
{
    // Display the menu of activities.
    Console.WriteLine("Please choose an activity:");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Reflection Activity");
    Console.WriteLine("3. Listing Activity");
    Console.WriteLine("4. Quit");

    // Get user input and validate it.
    // If the user chose to quit, exit the program.
    // Prompt the user to enter a duration for the activity.
    // Prepare to start the activity.
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid input. Please choose a number from 1 to 4.");
        continue;
    }
    if (choice == 4)
    {
        Console.WriteLine("Thank you for using Mindfulness App!");
        break;
    }
    Console.Write("Enter duration in seconds: ");
    int duration;
    while (!int.TryParse(Console.ReadLine(), out duration) || duration < 1)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }

    Console.WriteLine("Prepare to begin in:");
    // Prepare to start the activity.
    string[] spinner = { "/", "-", "\\", "|" };
    int index = 0;
    for (int i = 3; i >= 1; i--)
    {
        Console.WriteLine(i);
        Console.Write("Prepare to begin in ");
        Console.Write(spinner[index]);
        Console.CursorLeft--;
        index = (index + 1) % spinner.Length;
        Thread.Sleep(1000);
        Console.Clear();
    }
    Console.WriteLine("Go!");

    // Start the selected activity.
    // Create a new instance of the BreathingActivity class and start the activity.
    // Create a new instance of the ReflectionActivity class and start the activity.
    // Create a new instance of the ListingActivity class and start the activity.
    switch (choice)
    {
        case 1:
            BreathingActivity(duration);
            var breathingActivity = new Namespace2.BreathingActivity();
            breathingActivity.StartActivity(duration);
            break;
        case 2:
            ReflectionActivity(duration);
            var reflectionActivity = new Namespace3.ReflectionActivity();
            reflectionActivity.StartActivity(duration);
            break;
        case 3:
            ListingActivity(duration);
            var listingActivity = new ListingActivity();
            listingActivity.StartActivity(duration);
            break;
    }

    // The activity has ended.
    Console.WriteLine("Good job! You have completed the activity.");
    Console.WriteLine();
}

void ListingActivity( int duration)
{
    throw new NotImplementedException();
}

void BreathingActivity(int duration)
{
    Console.WriteLine("Breathing Activity: This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    for (int i = 0; i < duration; i += 2)
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe out...");
        Thread.Sleep(1000);
    }
}

void ReflectionActivity(int duration)
{
    Console.WriteLine("Reflection Activity: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    Random random = new();
    while (duration > 0)
    {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);
        }
    }
}