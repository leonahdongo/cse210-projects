using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

// inherit a class from the Base Goal class
// use protection property so that we inherit the date from the Base Goal Class
// declare public keywords to accessed by other files.
//
class EternalGoal : GoalBase
{
    protected int _timesCompleted;
    
    public EternalGoal(string goalString)
    {
        stategoalType = "EternalGoal";
        string[] splitString = goalString.Split(',');
        stategoalName = splitString[0];
        stategoalExplanation = splitString[1];
        stategoalPoints = Int32.Parse(splitString[2]);
    }
    
    public EternalGoal(string goalName,string goalExplanation,string goalPoints)
    {
        stategoalName = goalName;
        stategoalExplanation = goalExplanation;
        stategoalPoints = Int32.Parse(goalPoints);
        completedScore = " ";
        stategoalType = "EternalGoal";
        
        _timesCompleted = 0;
    }
    // perform public override method to our sub class Eternal Goals
    // return the files in our sub classes
    // make use of a command word
    public override void updateGoal()
    {
        _timesCompleted++;
    }
    public override int getPoints()
    {
        return stategoalPoints;
    }
    public override bool isComplete()
    {
        return false;
    }
    public override string getSaveGoal()
    {
        return stategoalType + ":" + stategoalName + "," + stategoalExplanation + "," + stategoalPoints;
    }
    public override string displayGoalInfo()
    {
        string returnString;
        returnString =" [ ] " + stategoalName + " (" + stategoalExplanation + ")";
        return returnString;
    }
}