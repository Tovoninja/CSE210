public static class Calculator
{
    public static int CalculateVillagerTotal(int villagerTotal, int house, bool mode)
    {
        if (mode)
        {
            return (villagerTotal + 1) * house;
        }

        return villagerTotal;
    }

    public static int RemoveVillagers(int villagerTotal, int send)
    {
        if (send <= villagerTotal)
        {
            return villagerTotal - send;
        }

        return villagerTotal;
    }

    public static int CalculateFoodWorkerTotal(int foodWorkerTotal, int newWorker)
    {
        return foodWorkerTotal + newWorker;
    }

    public static int CalculateWoodWorkerTotal(int woodWorkerTotal, int newWorker)
    {
        return woodWorkerTotal + newWorker;
    }

    public static int CalculateStoneWorkerTotal(int stoneWorkerTotal, int newWorker)
    {
        return stoneWorkerTotal + newWorker;
    }

    public static int CalculateGoldWorkerTotal(int goldWorkerTotal, int newWorker)
    {
        return goldWorkerTotal + newWorker;
    }

    public static int CalculateFoodTotal(int foodTotal, int tool, bool mode)
    {
        if (mode)
        {
            return (foodTotal + 1) * tool;
        }

        return foodTotal;
    }

    public static int CalculateWoodTotal(int woodTotal, int tool, bool mode)
    {
        if (mode)
        {
            return (woodTotal + 1) * tool;
        }

        return woodTotal;
    }

    public static int CalculateStoneTotal(int stoneTotal, int tool, bool mode)
    {
        if (mode)
        {
            return (stoneTotal + 1) * tool;
        }

        return stoneTotal;
    }

    public static int CalculateGoldTotal(int goldTotal, int tool, bool mode)
    {
        if (mode)
        {
            return (goldTotal + 1) * tool;
        }

        return goldTotal;
    }
}