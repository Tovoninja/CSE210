using System;

public class Menu
{
    private string _userChoice;
    private Goals _goals;

    public Menu()
    {
        _userChoice = "";
        _goals = new Goals();
    }

    public void ProcessMenu()
    {
        Console.WriteLine($"You have {_goals.GetTotalPoints()} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");

        _userChoice = Console.ReadLine();
        Console.WriteLine();

        switch (_userChoice)
        {
            case "1":
                CreateGoal();
                break;

            case "2":
                _goals.DisplayAllGoals();
                break;

            case "3":
                Console.Write("Enter filename: ");
                string saveFileName = Console.ReadLine();
                
                _goals.SaveGoalsToFile(saveFileName);
                break;

            case "4":
                Console.Write("Enter filename: ");
                string loadFileName = Console.ReadLine();
                _goals.GetGoalsFromFile(loadFileName);
                break;

            case "5":
                _goals.DisplayGoalNames();
                Console.Write("Which goal did you accomplish? ");
                int goalNumber = int.Parse(Console.ReadLine()) - 1;
                _goals.RecordEvent(goalNumber);
                break;

            case "6":
                Console.WriteLine("Goodbye.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RunProgram()
    {
        while (_userChoice != "6")
        {
            ProcessMenu();

            if (_userChoice != "6")
            {
                Console.WriteLine();
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    // this is to make the call for making a goal more simple
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());


        // we are going to use if and else this will alow us to use the classes in a simple way this will reduse the amount of code we write
        if (goalType == "1")
        {
            _goals.AppendGoal(new SimpleGoal(goalName, goalDescription, goalPoints));
            Console.WriteLine("Simple Goal created.");
        }
        else if (goalType == "2")
        {
            _goals.AppendGoal(new EternalGoal(goalName, goalDescription, goalPoints));
            Console.WriteLine("Eternal Goal created.");
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalRepetitions = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonusPoints = int.Parse(Console.ReadLine());

            _goals.AppendGoal(new CheckListGoal(goalName, goalDescription, goalPoints, goalRepetitions, goalBonusPoints));
            Console.WriteLine("CheckList Goal created.");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
}