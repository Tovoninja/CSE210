
class Job
{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJOb()
    {
        Console.WriteLine($"Name: {_companyName}, Title: {_jobTitle}, Started: {_startYear}, Ended: {_endYear}");
    }
}