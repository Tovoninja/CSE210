


class Program
{
    // It all starts simple this is the start of the code
    static async Task Main()
    {
        Game game = new Game();
        await game.Run();
    }
}


// using System;
// using System.Threading.Tasks;

// class Program
// {

//     static volatile int _villagerTotal = 0;
//     static async Task Main()
//     {
        
//         int house = 1;
//         bool mode = false;

//         _ = Task.Run(async () =>
//         {
//             while (true)
//             {
//             await Task.Delay(1000);
//                 mode = !mode;

//                 if (mode)
//                 {
//                     _villagerTotal = (_villagerTotal + 1) * house;
//                 }
                
//             }
//         });


//         Console.Clear();


//         while (true)
//         {



//             Console.SetCursorPosition(0,0);
//             Console.WriteLine($"Number of Villagers: {_villagerTotal}");
//             Console.WriteLine("1. Upgrades available");
//             Console.WriteLine("2. Assign Villagers to work");
//             Console.WriteLine("3. Kill a monster");

           

            
//             if (Console.KeyAvailable)
//             {
//                 char key = Console.ReadKey(true).KeyChar;

//                 switch (key)
//                 {
//                     case '1':
//                         Console.Clear();
//                         bool inUpgradeMenu = true;
//                         while (inUpgradeMenu)
//                         {
//                             Console.SetCursorPosition(0,0);
//                             Console.WriteLine($"Number of Villagers: {_villagerTotal}");
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine("1. Upgrade House");
//                             Console.WriteLine("2. Upgrade Tools");
//                             Console.WriteLine("0. <-- Back");
//                             Console.ResetColor();

//                             if(Console.KeyAvailable)
//                             {
//                                 char key2 = Console.ReadKey(true).KeyChar;

//                                 switch (key2)
//                                 {
//                                     case '1':
//                                         Console.WriteLine("You Upgraded number of house");
//                                         break;
//                                     case '2':
//                                         Console.WriteLine("You Upgraded Your Tools");
//                                         break;
//                                     case '0':
//                                         inUpgradeMenu = false;
//                                         Console.Clear();
//                                         break;
//                                 }
                                
//                             }

                           
//                         }
//                         break;

//                     case '2':
//                         Console.Clear();
//                         bool inTaskMenu = true;
//                         while (inTaskMenu)
//                         {
//                             Console.SetCursorPosition(0,0);
//                             Console.WriteLine($"Number of Villagers: {_villagerTotal}");
//                             Console.ForegroundColor = ConsoleColor.Red;
//                             Console.WriteLine("1. Food");
//                             Console.WriteLine("2. Lumber");
//                             Console.WriteLine("3. Stone");
//                             Console.WriteLine("4. Gold");
//                             Console.WriteLine("0. <-- Back");
//                             Console.ResetColor();

//                             if(Console.KeyAvailable)
//                             {
//                                 char key2 = Console.ReadKey(true).KeyChar;

//                                 switch (key2)
//                                 {
//                                     case '1':
//                                         Console.WriteLine("Number villagers are now getting more Food");
//                                         break;
//                                     case '2':
//                                         Console.WriteLine("Number villagers are now getting more Wood");
//                                         break;
//                                     case'3':
//                                         Console.WriteLine("Number villagers are now getting more Stone");
//                                         break;
//                                     case'4':
//                                         Console.WriteLine("Number villagers are now getting more Gold");
//                                         break;
//                                     case '0':
//                                         inTaskMenu = false;
//                                         Console.Clear();
//                                         break;
//                                 }
                                
//                             }

                            
//                         }
//                         break;
                        

//                     case '3':
//                         Console.WriteLine("You kill a monster.");
//                         break;

//                     default:
//                         Console.WriteLine("Invalid option.");
//                         break;
//                 }

//             }    

//         await Task.Delay(100);

//         }
//     }
// }