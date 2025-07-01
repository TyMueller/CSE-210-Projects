using System;

namespace Learning02;

public class Job
    {
    public string _company;
        public string _jobTitle = "";
        public int _startYear; //Default set to zero
        public int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear) //Explain why I need this here but not in the other class
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }
    public void Display()
    {
        Console.WriteLine($"\"{_jobTitle} ({_company}) {_startYear}-{_endYear}\"");
    }
    
    }
