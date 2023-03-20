using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class Program
{
    public static void Main()
    {
        goals = new List<GoalBase>();
        totalNumPoints = 0;
        ShowMenu();
    }
    private static List<GoalBase> goals;
    private static int totalNumPoints;
    
    public static void NewGoal()
        {
            Console.WriteLine("The goals that we have are as follows: ");
            Console.WriteLine("1. Simple Goal: ");
            Console.WriteLine("2. Eternal Goal: ");
            Console.WriteLine("3. CheckList Goal: ");
            
            string stateYourResponse = Console.ReadLine();
            string stategoalType;
            string stategoalExplanation;
            string stategoalPoints;
            
            if (stateYourResponse == "1")
            {
                Console.WriteLine ("Please set the type of the goal you want to work with. ");
                stategoalType = Console.ReadLine();
                Console.WriteLine ("What is your explanion of the goal type you selected? ");
                stategoalExplanation = Console.ReadLine();
                Console.WriteLine ("State the number of points you want for the goal you selected.");
                stategoalPoints = Console.ReadLine();
                if (Int32.Parse(stategoalPoints) < 0)
                {
                    Console.WriteLine("Be warned!. We need positive response.");
                }
                else
                {
                    goals.Add(new SimpleGoal(stategoalType, stategoalExplanation, stategoalPoints));
                }
            }
            
            else if (stateYourResponse == "2")
            {
                Console.WriteLine ("Please set the type of the goal you want to work with. ");
                stategoalType = Console.ReadLine();
                Console.WriteLine ("What is your explanion of the goal type you selected? ");
                stategoalExplanation = Console.ReadLine();
                Console.WriteLine ("State the number of points you want for the goal you selected.");
                stategoalPoints = Console.ReadLine();
                if (Int32.Parse(stategoalPoints) < 0)
                {
                    Console.WriteLine("Be warned!. We need positive response.");
                }
                else
                {
                    goals.Add(new EternalGoal(stategoalType, stategoalExplanation, stategoalPoints));
                }
            }
            
            else if (stateYourResponse == "3")
            {
                string CompletedTimes;
                string ExtraPoints;
                
                Console.WriteLine ("Please set the type of the goal you want to work with. ");
                stategoalType = Console.ReadLine();
                Console.WriteLine ("What is your explanion of the goal type you selected? ");
                stategoalExplanation = Console.ReadLine();
                Console.WriteLine ("State the number of points you want for the goal you selected.");
                stategoalPoints = Console.ReadLine();
                Console.WriteLine ("please state the number times this goal requires to be completed?");
                CompletedTimes = Console.ReadLine();
                Console.WriteLine ("What is the price for completing multiple times?");
                ExtraPoints = Console.ReadLine();
                if (Int32.Parse(stategoalPoints) < 0 || Int32.Parse(ExtraPoints) < 0)
                {
                    Console.WriteLine("Be warned!. We need positive response.");
                }
                else
                {
                    goals.Add(new ChecklistGoal(stategoalType, stategoalExplanation, stategoalPoints, CompletedTimes, ExtraPoints));
                }
            }
            
            else
            {
                Console.WriteLine("You have stated a wrong selection. Please enter the correct one.");
            }
        }
        
    public static void ListGoals()
        {
            int goalNumber = 1;
            Console.WriteLine("The goals are: ");
            foreach (GoalBase goal in goals)
            {
                Console.Write(goalNumber + ". ");
                Console.WriteLine(goal.displayGoal());
                goalNumber++;
            }
        }
        
    public static void SaveGoal()
        {
        Console.WriteLine("Enter a filename to save the goals to:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalNumPoints);
            foreach (GoalBase goal in goals)
            {
                outputFile.WriteLine(goal.getSaveGoal());
            }
        }
        }
        
    public static void LoadGoal()
    {
        Console.WriteLine("Enter a filename to load the goals from:");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        goals.Clear();
        
        totalNumPoints = Int32.Parse(lines[0]);
        for (int iter = 1; iter < lines.Length; iter++)
        {
            string[] typeSplit = lines[iter].Split(':');
            
            if (typeSplit[0] == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(typeSplit[1]));
            }
            else if (typeSplit[0] == "EternalGoal")
            {
                goals.Add(new EternalGoal(typeSplit[1]));
            }
            else if (typeSplit[0] == "CheckListGoal")
            {
                goals.Add(new ChecklistGoal(typeSplit[1]));
            }

        }
    } 
    // CLASS BEHAVOURS FOR THIS SECTION 
    // record the events in our goal base file in public
    // we will show our completed goals and return the true command 
    // create loops for our goal selections
    // do the calculations to obtain the total points 

    public static void RecordEvent()
    {
        int goalNum = 1;
        int goalSelection = 0;
        Console.WriteLine("The goals are: ");
        foreach (GoalBase goal in goals)
        {
            Console.Write(goalNum + ". ");
            Console.WriteLine(goal.getGoalName());
            goalNum++;
        }
        Console.WriteLine("State the goal that you COMPLETED!?");
        goalSelection = Int32.Parse(Console.ReadLine());
        goalSelection--;
        
        if (goalSelection >= 0 && goalSelection <= goals.Count)
        {
            if (goals[goalSelection].isComplete() == true)
            {
                Console.WriteLine ("You are now repeating!");
            }
            else
            {
                goals[goalSelection].updateGoal();
                totalNumPoints = totalNumPoints + goals[goalSelection].getPoints();
            }
            
        }
    }
     // MENU SELECTION AREA
     // create while loop for this section
     // create the total numer of points
     // create a new goal for our file
     // list the goals that we have in our file
     // save goals to file
     // load our goal to our file
     // record  all tHe event taking place 
    public static void ShowMenu()
        {
            string input = "";
            while (input != "6")
            {
                Console.WriteLine("You have " + totalNumPoints + " points.\n");
                Console.WriteLine("Menu options:");
                Console.WriteLine(" 1. Create a new goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");
                Console.WriteLine();
    
                Console.WriteLine("Please state your selection:");
                input = Console.ReadLine();
    
                if (input == "1")
                {
                    NewGoal();
                }
                else if (input == "2")
                {
                    ListGoals();
                }
                else if (input == "3")
                {
                    SaveGoal();
                }
                else if (input == "4")
                {
                    LoadGoal();
                }
                else if (input == "5")
                {
                    RecordEvent();
                }
                else if (input == "6")
                {
                    Console.WriteLine("The End.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }
        
}