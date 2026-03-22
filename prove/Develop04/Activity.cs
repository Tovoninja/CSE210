
class Activity
{
    // these are my the variables to start of the code
    private string _name;
    private string _description;
    private int _duration;

    // So that I can have a perent class for the assinment lets declare how Activity works
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    // this will be used in my program so that I can call this in program
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

    int duration;

    while (true)
    {
        Console.Write("Enter a positive number: ");

    try
    {
        duration = int.Parse(Console.ReadLine());

        if (duration > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Number must be greater than 0.");
        }
    }
        catch
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    }

        SetDuration(duration);

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Leeeeets Freeeeeking Goooooooo!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string current = spinnerStrings[i];
            Console.Write(current);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}
