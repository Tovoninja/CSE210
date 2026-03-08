using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu ();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                // Create new Journal Entry
                // Add entry to list of journal entries
                Case1 case1 = new Case1(); 
                Console.WriteLine(case1.GetRandomPrompt());
                Console.Write("> ");

                // Get the curent date and time of the log
                DateTime now = DateTime.Now;

                string Log = Console.ReadLine();

                Console.WriteLine(Directory.GetCurrentDirectory());
                File.AppendAllText("journal.txt", now + " " + Log + "\n");
                Console.WriteLine("Entry saved.");
                
                break;
                case 2:
                // Display Journal Entries
                break;
                case 3:
                // Save jounal to file
                break;
                case 4:
                // Load journal from file
                break;
                case 5:
                    done = true;
                    break;
            }


        } while (!done);

        
    }
}