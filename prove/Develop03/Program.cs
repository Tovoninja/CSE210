using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture yourScripture = new Scripture();
        Word picker = new Word();

        Console.WriteLine("What is the scripture you are going to memorize?");
        string scriptureName = Console.ReadLine();

        //This is for getting the list to go to my other class called sctipture!
        Console.WriteLine("Copy and past the scipture that you would like to use: ");
        string verse = Console.ReadLine();
        yourScripture.AddParagraph(verse);


        //clear the console
        Console.Clear();


            while(true)
            {
                Console.Clear();
                Console.Write(scriptureName + " ");

                for(int i = 0; i < yourScripture.scriptures.Count; ++i)
                {
                    
                    Console.Write(yourScripture.scriptures[i] + " ");
                }
                
                Console.WriteLine();
                Console.WriteLine("Click enter to remove more words.");
                string choice = Console.ReadLine();

                if(choice == "")
                {
                    picker.PickWord(yourScripture);                              
                }
                else if (choice == "quit")
                {
                    break;
                }
            }
        
        
    }
}