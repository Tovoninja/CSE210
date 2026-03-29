using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<Goal> GoalsList;
    private int _totalPoints;

    public Goals()
    {
        GoalsList = new List<Goal>();
        _totalPoints = 0;
    }

    public void AppendGoal(Goal goal)
    {
        GoalsList.Add(goal);
    }

    public void CalculateTotalPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    public void DisplayAllGoals()
    {
        if (GoalsList.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        for (int i = 0; i < GoalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalsList[i].DisplayGoal()}");
        }
    }

    public void DisplayGoalNames()
    {
        if (GoalsList.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        for (int i = 0; i < GoalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {GoalsList[i].GetGoalName()}");
        }
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber < 0 || goalNumber >= GoalsList.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = GoalsList[goalNumber];
        int earnedPoints = selectedGoal.GetCompletedPoints();

        if (earnedPoints > 0)
        {
            selectedGoal.UpdateInfo();
            _totalPoints += earnedPoints;

            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
        else
        {
            Console.WriteLine("This goal is already complete, so no points were awarded.");
        }
    }

    public void SaveGoalsToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in GoalsList)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void GetGoalsFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        GoalsList.Clear();

        if (lines.Length > 0)
        {
            _totalPoints = int.Parse(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);

                GoalsList.Add(new SimpleGoal(name, description, points, status));
            }
            else if (parts[0] == "CheckListGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int repetitions = int.Parse(parts[4]);
                int completions = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);

                GoalsList.Add(new CheckListGoal(name, description, points, repetitions, bonusPoints, completions));
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int completions = int.Parse(parts[4]);

                GoalsList.Add(new EternalGoal(name, description, points, completions));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}