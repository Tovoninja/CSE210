using System;

public class EternalGoal : Goal
{
    private int _completions;

    // this alows us to put everything within a peramiter 
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completions = 0;
    }

    public EternalGoal(string name, string description, int points, int completions)
        : base(name, description, points)
    {
        _completions = completions;
    }



    // Override is nice because we want to change the number of points that we have 
    public override void SetPoints(int points)
    {
        base.SetPoints(points);
    }

    // we also want to add 1 to the value of completions
    public override void UpdateInfo()
    {
        _completions++;
    }


    // this calls the GetPoints in the Goal we set up so that way we can take the number and override it 
    public override int GetCompletedPoints()
    {
        return GetPoints();
    }

    public override bool GetStatus()
    {
        return false;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {GetGoalName()} ({GetGoalDescription()})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{GetGoalName()}|{GetGoalDescription()}|{GetPoints()}|{_completions}";
    }
}