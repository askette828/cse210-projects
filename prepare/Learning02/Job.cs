namespace Classes;

public class Job
{
    public string _jobTitle;
    public string _companyName;

    public int _startYear;
    public int _endYear;

    public Job(string jobTitle, string companyName, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    public string _name;
    public List<Job> Jobs = new List<Job>();

    public void Display()
    {
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}