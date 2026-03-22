using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

public static class Menu
{
    public static async Task ShowUpgradeMenu()
    {
        Console.Clear();
        bool inUpgradeMenu = true;

        while (inUpgradeMenu)
        {
            // This is for the left side of console going down
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Number of Villagers: {Game.villagerTotal}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Upgrade House");
            Console.WriteLine("2. Upgrade Tools");
            Console.WriteLine("0. <-- Back");
            Console.ResetColor();


            Stats();



            if (Console.KeyAvailable)
            {
                char key2 = Console.ReadKey(true).KeyChar;

                switch (key2)
                {
                    case '1':
                        Console.WriteLine("You Upgraded number of house");
                        break;
                    case '2':
                        Console.WriteLine("You Upgraded Your Tools");
                        break;
                    case '0':
                        inUpgradeMenu = false;
                        Console.Clear();
                        break;
                }
            }

            await Task.Delay(100);
        }
    }

    public static async Task ShowTaskMenu()
    {
        Console.Clear();
        bool inTaskMenu = true;

        while (inTaskMenu)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Number of Villagers: {Game.villagerTotal}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"1. Food: {Game.foodWorkerTotal}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"2. Lumber: {Game.woodWorkerTotal}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"3. Stone: {Game.stoneWorkerTotal}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"4. Gold: {Game.goldWorkerTotal}");

            Console.ResetColor();
            Console.WriteLine("0. <-- Back");
            

            Stats();

            if (Console.KeyAvailable)
            {
                char key2 = Console.ReadKey(true).KeyChar;

                switch (key2)
                {
                    case '1':
                        Resource.WoodMenu();
                        break;                        
                    case '2':
                        Console.WriteLine("Number villagers are now getting more Wood");
                        break;
                    case '3':
                        Console.WriteLine("Number villagers are now getting more Stone");
                        break;
                    case '4':
                        Console.WriteLine("Number villagers are now getting more Gold");
                        break;
                    case '0':
                        inTaskMenu = false;
                        Console.Clear();
                        break;
                }
            }

            await Task.Delay(100);
        }
            }

        public static void Stats()
            {
        
                // This is for the Right likewise
                int width = Console.WindowWidth;
                int rightX = width - 20;

                // FOOD
                Console.SetCursorPosition(rightX, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Food: {Game.foodTotal}");

                // WOOD
                Console.SetCursorPosition(rightX, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Wood: {Game.woodTotal}");

                // Stone
                Console.SetCursorPosition(rightX -1, 2);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Stone: {Game.stoneTotal}");

                // Gold
                Console.SetCursorPosition(rightX, 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Gold: {Game.goldTotal}");

                Console.ResetColor();
    }
}