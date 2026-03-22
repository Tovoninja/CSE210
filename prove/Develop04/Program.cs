using System;

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {


        List<string> activityLog = new List<string>();
        bool running = true;


        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. View session log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            // This is a fun thing I learned on my oun it allows you to instantly read the input and it comits it as true immedietely
            char choice = Console.ReadKey(true).KeyChar;




            switch (choice)
            {
                case '1':
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityLog.Add($"{DateTime.Now:G} Has Been Completed {breathing.GetName()} for {breathing.GetDuration()} seconds");
                    break;
                case '2':
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    activityLog.Add($"{DateTime.Now:G} Has Been Completed {reflection.GetName()} for {reflection.GetDuration()} seconds");
                    break;
                case '3':
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityLog.Add($"{DateTime.Now:G} Has Been Completed {listing.GetName()} for {listing.GetDuration()} seconds");
                    break;
                case '4':
                    ShowLog(activityLog);
                    break;
                case '5':
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void ShowLog(List<string> activityLog)
    {
        Console.Clear();
        Console.WriteLine("Session Log");
    

        if (activityLog.Count == 0)
        {
            Console.WriteLine("No activities completed yet.");
        }
        else
        {
            foreach (string entry in activityLog)
            {
                Console.WriteLine(entry);
            }
        }

        Console.WriteLine();
        Console.Write("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}


