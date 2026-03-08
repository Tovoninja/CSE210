class Resume
{
    public string _name;
    
    public List<Job> _jobs;

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");

        foreach(Job Job in _jobs)
        {
            Console.WriteLine(Job);
        }
    }
}