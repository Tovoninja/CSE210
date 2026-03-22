
class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Queue<string> _promptQueue;
    private Queue<string> _questionQueue;
    private Random _random;

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _promptQueue = new Queue<string>();
        _questionQueue = new Queue<string>();

        RefillPromptQueue();
        RefillQuestionQueue();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetNextPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetNextQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
            Console.WriteLine();
        }

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

    private string GetNextQuestion()
    {
        if (_questionQueue.Count == 0)
        {
            RefillQuestionQueue();
        }

        return _questionQueue.Dequeue();
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

    private void RefillQuestionQueue()
    {
        List<string> shuffled = new List<string>(_questions);
        ShuffleList(shuffled);

        foreach (string item in shuffled)
        {
            _questionQueue.Enqueue(item);
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

