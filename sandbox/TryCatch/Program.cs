

class Program
{
    public static int GetAge()
    {
        int age = 0;
        bool done = false;

        while (!done)
        {
            try
            {
                Console.Write("What is your age?");
                age = int.Parse(Console.ReadLine());
                if (age >= 0 && age <= 125)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please enter A Number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("Please enter a valid age.");
                }
            }   

            
        }
        return age;

    public static void Main(string[] args)
    {
        Console.WriteLine($"Your age is: {GetAge()}");
    }
    }
}