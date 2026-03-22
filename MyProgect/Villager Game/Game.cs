using System;
using System.Threading.Tasks;

public class Game
{
    // This is the idel villagers the life blood of the game
    public static volatile int villagerTotal = 0;

    // These are for assignd villagers
    public static volatile int foodWorkerTotal = 0;
    public static volatile int woodWorkerTotal = 0;
    public static volatile int stoneWorkerTotal = 0;
    public static volatile int goldWorkerTotal = 0;

    // These are for Resorses
    public static volatile int foodTotal = 0;
    public static volatile int woodTotal = 0;
    public static volatile int stoneTotal = 0;
    public static volatile int goldTotal = 0;



    // this is for the intian of the game itself
    public async Task Run()
    {   
        //start by giving the player no upgrades for now
        int house = 1;
        int tool = 1;
        bool mode = false;


        // this is a bit complicated but the _= makes this bit able to run no matter what this is the cause of the pulse or tick that is the whole point of this game
        _ = Task.Run(async () =>
        {   
            // the tick or clock that we run on
            while (true)
            {
                await Task.Delay(1000);
                mode = !mode;

                // The Math of what is efected by said clock
                if (mode)
                {
                    villagerTotal = Calculator.CalculateVillagerTotal(villagerTotal, house, mode);
                    foodTotal = Calculator.CalculateFoodTotal(foodTotal, tool, mode) * foodWorkerTotal;
                    woodTotal = Calculator.CalculateWoodTotal(woodTotal, tool, mode) * woodWorkerTotal;
                    stoneTotal = Calculator.CalculateStoneTotal(stoneTotal, tool, mode) * stoneWorkerTotal;
                    goldTotal = Calculator.CalculateGoldTotal(goldTotal, tool, mode) * goldWorkerTotal;
                }
            }
        });

        Console.Clear();


        // Main menu the first directory if you will
        while (true)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Number of Villagers: {villagerTotal}");
            Console.WriteLine("1. Upgrades available");
            Console.WriteLine("2. Assign Villagers to work");
            Console.WriteLine("3. Kill a monster");

            Menu.Stats();

            // this functions by waiting on a key press from the user that will instantly be flaged as true and then move the player deaper into other menus
            if (Console.KeyAvailable)
            {
                char key = Console.ReadKey(true).KeyChar;

                switch (key)
                {
                    case '1':
                        await Menu.ShowUpgradeMenu();
                        break;

                    case '2':
                        await Menu.ShowTaskMenu();
                        break;

                    case '3':
                        Console.WriteLine("You kill a monster.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            await Task.Delay(100);
        }
    }
}