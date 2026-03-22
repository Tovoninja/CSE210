
class Police : Person
{
    private string _tools;
    public Police(string weapon, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        string _weapon = weapon;
    }

    public string GetPoliceInformation()
    {
        return $"Tools: {_tools}, {GetPersonInformation()}";
    }
}