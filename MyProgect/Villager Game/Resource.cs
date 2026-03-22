class Resource
{
    
    public static async Task WoodMenu()
    {
        
        bool woodMenu = true;

        while(woodMenu)
        {

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Number of Villagers: {Game.villagerTotal}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How Many Villagers do you want to become Farmers");
            Console.WriteLine("1. 1   Villager");
            Console.WriteLine("2. 5   Villagers");
            Console.WriteLine("3. 10  Villagers");
            Console.WriteLine("Click Period(.) All");
            Console.ResetColor();
            Console.WriteLine("0. <-- Back");

            char key = Console.ReadKey(true).KeyChar;
            switch(key)
            {
            case '1':
                Game.villagerTotal = Calculator.RemoveVillagers(Game.villagerTotal, 1);
                Game.foodWorkerTotal = Calculator.CalculateFoodWorkerTotal(Game.foodWorkerTotal, 1);
                break;
            case '2':
                Game.villagerTotal = Calculator.RemoveVillagers(Game.villagerTotal, 5);
                Game.foodWorkerTotal = Calculator.CalculateFoodWorkerTotal(Game.foodWorkerTotal, 5);
                break; 
            case '3':
                Game.villagerTotal = Calculator.RemoveVillagers(Game.villagerTotal, 10);
                Game.foodWorkerTotal = Calculator.CalculateFoodWorkerTotal(Game.foodWorkerTotal, 10);
                break;
            case '.':
                Game.villagerTotal = Calculator.RemoveVillagers(Game.villagerTotal, Game.villagerTotal);
                Game.foodWorkerTotal = Calculator.CalculateFoodWorkerTotal(Game.foodWorkerTotal, Game.villagerTotal);
                break;
            case '0':
                woodMenu = false;
                break;

            }    
        }
    }
}