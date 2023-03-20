using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

// Perform abstaction task for our Goal base sub class
// Use protected methods to allow us to inherit from our goal base class.
// public abstract method for our files in our goal base class and sub classes
abstract class GoalBase{
    protected int stategoalPoints;
    protected string stategoalExplanation;
    protected string stategoalName;
    protected string stategoalType;
    protected string completedScore;
    
    public abstract string getSaveGoal();
    public abstract void updateGoal();
    public abstract bool isComplete();
    public abstract string displayGoalInfo();
    public abstract int getPoints();
    
    public string getGoalName()
    {
        return stategoalName;
    }
    internal bool displayGoal()
    {
        throw new NotImplementedException();
    }
}