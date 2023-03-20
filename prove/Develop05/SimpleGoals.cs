using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

// inherit a class from the base goal class
// perform method overriding in our class
// 
class SimpleGoal : GoalBase
{
    private bool completed;

    public SimpleGoal(string goalString)
    {
        stategoalType = "SimpleGoal";
        string[] splitString = goalString.Split(',');
        stategoalName = splitString[0];
        stategoalExplanation = splitString[1];
        stategoalPoints = Int32.Parse(splitString[2]);
        completed = bool.Parse(splitString[3]);
        if (completed == true)
        {
            completedScore = "X";
        }
        else
        {
            completedScore = " ";
        }
    }
    
    public SimpleGoal(string goalName,string goalDescription,string goalPoints)
    {
        stategoalName = goalName;
        stategoalExplanation = goalDescription;
        stategoalPoints = Int32.Parse(goalPoints);
        completed = false;
        completedScore = " ";
        stategoalType = "SimpleGoal";
        
    }
    public override void updateGoal()
    {
        completed = true;
        completedScore = "X";
    }
    public override string getSaveGoal()
    {
        return stategoalType + ":" + stategoalName + "," + stategoalExplanation + "," + stategoalPoints + "," + completed;
    }
    public override int getPoints()
    {
        int points = 0;
        if (completed == true)
        {
            points = stategoalPoints;
        }
        return points;
    }
    // use public override to conduct our implimantation
    // return our points when complete
    public override bool isComplete()
    {
        return completed;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [" + completedScore + "] " + stategoalName + " (" + stategoalExplanation + ")";
        return returnString;
    }
}