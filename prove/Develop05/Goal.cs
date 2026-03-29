using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    // First we declare the varubles for the parent class for all of our other classes
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // This is the Abstract Atubute required for the assignment
    public abstract string DisplayGoal();

    // This is for the names of things 
    public void SetGoalName(string name)
    {
        _name = name;
    }

    public string GetGoalName()
    {
        return _name;
    }



    // Then we need a name for some of the things
    public string GetGoalDescription()
    {
        return _description;
    }

    public void SetGoalDescription(string description)
    {
        _description = description;
    }


    // Set the point amount and get said points
    public virtual void SetPoints(int points)
    {
        _points = points;
    }

    // this will be used to return the number of all the points 
    public int GetPoints()
    {
        return _points;
    }


    // abstract things
    public abstract int GetCompletedPoints();

    public abstract void UpdateInfo();

    public abstract bool GetStatus();

    public abstract string GetSaveString();
}