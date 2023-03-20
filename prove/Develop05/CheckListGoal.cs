using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class ChecklistGoal : GoalBase
{
    protected int CompletedTimes;
    protected int timesCompleted;
    protected int ExtraPoints;
    protected int sategoalPoints;
    
    public ChecklistGoal(string goalString)
    {
        stategoalType = "ChecklistGoal";
        string[] splitString = goalString.Split(',');
        stategoalName = splitString[0];
        stategoalExplanation = splitString[1];
        stategoalPoints = Int32.Parse(splitString[2]);
        ExtraPoints = Int32.Parse(splitString[3]);
        CompletedTimes = Int32.Parse(splitString[4]);
        timesCompleted = Int32.Parse(splitString[5]);
        if (timesCompleted == CompletedTimes)
        {
            completedScore = "X";
        }
        else
        {
            completedScore = " ";
        }
    }
    
  public ChecklistGoal(string stategoalName, string stategoalDescription, string stategoalPoints, string CompletedTimes, string ExtraPoints)
    {
        stategoalName = stategoalName;
        stategoalDescription = stategoalDescription;
        stategoalPoints = Int32.Parse(sategoalPoints);
        CompletedTimes =Int32.Parse (CompletedTimes);
        ExtraPoints = Int32.Parse(ExtraPoints);
        completedScore = " ";
        stategoalType = "ChecklistGoal";
        
        timesCompleted = 0;
        
        
    }
    public override void updateGoal()
    {
        timesCompleted++;
        if (timesCompleted == CompletedTimes)
        {
            completedScore = "V";
        }
    }
    public override int getPoints()
    {
        int points = 0;
        if (timesCompleted == CompletedTimes)
        {
            points = ExtraPoints;
        }
        return points + stategoalPoints;
    }
    public override bool isComplete()
    {
        if (timesCompleted == CompletedTimes)
        {
            return true;
        }
        return false;
    }
   
    public override string getSaveGoal()
    {
        return stategoalType + ":" + stategoalName + "," + stategoalExplanation + "," + stategoalPoints + "," + ExtraPoints + "," + completedTimes + "," + timesCompleted;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [" + completedScore + "] " + stategoalName + " (" + stategoalExplanation + ") " + " You are done: " + timesCompleted + "/" + completedTimes;
        return returnString;
    }
}