using System;

public class SimpleGoal : Goal
{
    private bool _status;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _status = false;
    }

    public SimpleGoal(string name, string description, int points, bool status)
        : base(name, description, points)
    {
        _status = status;
    }



    public override void SetPoints(int points)
    {
        base.SetPoints(points);
    }

    public override void UpdateInfo()
    {
        if (_status == false)
        {
            _status = true;
        }
    }

    public override int GetCompletedPoints()
    {
        if (_status == false)
        {
            return GetPoints();
        }

        return 0;
    }

    public override bool GetStatus()
    {
        return _status;
    }


    // The X will apear at the begining to diclare if the goal has been marked done
    public override string DisplayGoal()
    {
        string mark;

        if (_status)
        {
            mark = "[X]";
        }
        else
        {
            mark = "[ ]";
        }

        return $"{mark} {GetGoalName()} ({GetGoalDescription()})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{GetGoalName()}|{GetGoalDescription()}|{GetPoints()}|{_status}";
    }
}