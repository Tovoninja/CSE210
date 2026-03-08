
class Case1
{
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int prompt = rand.Next(50);
        return prompts[prompt];
    }

    List<string> prompts = new List<string>()
    {
        "What made you smile today?",
        "What was the best part of your day?",
        "What challenged you today?",
        "What is something new you learned today?",
        "What surprised you today?",
        "What made today unique?",
        "What was the most interesting conversation you had today?",
        "What is something small that made your day better?",
        "What was something you are proud of today?",
        "What was the most relaxing part of your day?",
        "What did you spend the most time thinking about today?",
        "What motivated you today?",
        "What drained your energy today?",
        "What is something you wish went differently today?",
        "What is one thing you would do differently if you could repeat today?",
        "What moment today would you want to relive?",
        "What is something you are grateful for today?",
        "Who helped you today and how?",
        "What is something simple you appreciated today?",
        "What blessing did you notice today?",
        "What made you laugh today?",
        "What was the hardest thing you faced today?",
        "What is something kind you did for someone today?",
        "What is something kind someone did for you today?",
        "What was the most productive thing you did today?",
        "What is something that inspired you today?",
        "What goal did you work toward today?",
        "What habit are you working on right now?",
        "What is something you want to improve tomorrow?",
        "What is something you learned about yourself today?",
        "What is something you are excited about right now?",
        "What was your favorite moment today?",
        "What was the most peaceful moment of your day?",
        "What is something you are looking forward to tomorrow?",
        "What is something you did today that pushed you out of your comfort zone?",
        "What made today meaningful?",
        "What was something unexpected that happened today?",
        "What did you do today that made you feel accomplished?",
        "What did you do today to relax?",
        "What was something beautiful you noticed today?",
        "What did you enjoy doing the most today?",
        "What is something that made today difficult?",
        "What helped you get through a hard moment today?",
        "What is something you are thankful for in your life right now?",
        "What was something interesting you saw today?",
        "What is something that made you feel proud today?",
        "What is something that made you feel calm today?",
        "What is something you did today that helped someone else?",
        "What is something you wish you had more time for today?",
        "What is something you want to remember about today?"
    };

   

    
}