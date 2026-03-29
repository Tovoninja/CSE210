using System;

public class CheckListGoal : Goal
{
    private int _repetitions;
    private int _completions;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int repetitions, int bonusPoints)
        : base(name, description, points)
    {
        _repetitions = repetitions;
        _completions = 0;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal(string name, string description, int points, int repetitions, int bonusPoints, int completions)
        : base(name, description, points)
    {
        _repetitions = repetitions;
        _bonusPoints = bonusPoints;
        _completions = completions;
    }

    public override void SetPoints(int points)
    {
        base.SetPoints(points);
    }

    public override void UpdateInfo()
    {
        if (_completions < _repetitions)
        {
            _completions++;
        }
    }

    public override int GetCompletedPoints()
    {
        if (_completions < _repetitions)
        {
            if (_completions + 1 == _repetitions)
            {
                return GetPoints() + _bonusPoints;
            }

            return GetPoints();
        }

        return 0;
    }

    public override bool GetStatus()
    {
        return _completions >= _repetitions;
    }

    public override string DisplayGoal()
    {
        string mark;

        if (GetStatus())
        {
            mark = "[X]";
        }
        else
        {
            mark = "[ ]";
        }

        return $"{mark} {GetGoalName()} ({GetGoalDescription()}) -- Completed {_completions}/{_repetitions} times";
    }

    public override string GetSaveString()
    {
        return $"CheckListGoal|{GetGoalName()}|{GetGoalDescription()}|{GetPoints()}|{_repetitions}|{_completions}|{_bonusPoints}";
    }
}