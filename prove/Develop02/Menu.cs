
class Menu
{
    public string [] _menuStrings = {
        "Welcome to the Journal Program","You can creat Display, Save, and Load Jornal Entries",
        "1 - create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Read Journal from file",
        "5 - Quit"

    };

    public int ProcessMenu()
    {
        int userResponse = 0;

        do
        {
        foreach(string line in _menuStrings)
        {
            Console.WriteLine(line);
        }
        userResponse = int.Parse(Console.ReadLine());
        } while (userResponse < 1 || userResponse > 5);
        return userResponse;
        
    }
}