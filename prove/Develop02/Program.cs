using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu ();
        bool done = false;
        int userResponse;
        List<string> logs = new List<string>();
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
                string newLog = ($"{now} {Log}\n");
                logs.Add(newLog);
               
                
                
                break;
                case 2:
                // Display Journal Entries
                for (int i = 0; i < logs.Count; i++)
                    {
                        Console.WriteLine(logs[i]);
                    }
                // Console.WriteLine("did it call?");

                break;
                case 3:
                // Save jounal to file
                Console.WriteLine("What would you like to name your log?");
                Console.Write("> ");
                string nameOfLog = Console.ReadLine();
                if (nameOfLog.EndsWith(".txt"))
                    {
                        File.AppendAllText(nameOfLog, string.Join("\n", logs));
                        
                    }
                    else
                    {
                        File.AppendAllText(nameOfLog + ".txt", string.Join("\n", logs));
                        
                    }
                

                Console.WriteLine("Entry saved.");
                break;


                case 4:
                // Load journal from file
                Console.WriteLine("What file would you like to open?");
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
                
                for(int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine(Path.GetFileName(files[i]));                        
                    }
                Console.Write("> ");
                string getFile = Console.ReadLine();
                if (getFile.EndsWith(".txt"))
                    {
                        Console.WriteLine(File.ReadAllText(getFile));
                    }
                    else
                    {
                        Console.WriteLine(File.ReadAllText(getFile + ".txt"));
                    }


                break;


                
                case 5:
                    done = true;
                    break;
            }


        } while (!done);

        
    }
}