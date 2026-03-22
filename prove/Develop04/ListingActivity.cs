class ListingActivity : Activity
{
    private List<string> _prompts;
    private Queue<string> _promptQueue;
    private Random _random;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _promptQueue = new Queue<string>();
        RefillPromptQueue();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetNextPrompt()} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items!");

        DisplayEndingMessage();
        Console.WriteLine();
        Console.Write("Press Enter to continue.");
        Console.ReadLine();
    }

    private string GetNextPrompt()
    {
        if (_promptQueue.Count == 0)
        {
            RefillPromptQueue();
        }

        return _promptQueue.Dequeue();
    }

    private void RefillPromptQueue()
    {
        List<string> shuffled = new List<string>(_prompts);
        ShuffleList(shuffled);

        foreach (string item in shuffled)
        {
            _promptQueue.Enqueue(item);
        }
    }

    private void ShuffleList(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            string temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}