using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //Why do we have to define classes out here?
    public class Job //Explain the public meaning and what other options there are for classes
    {
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0; //Why do we have to specify that these are public when we already made the class public??

        public void Display() //Function within a class is called a method correct? Why does it have a special name?
        {
            Console.WriteLine($"\"{_jobTitle} ({_company}) {_startYear}-{_endYear}\"");
        }
    
    }

    public class Resume
    {
        public string _name = ""; //Empty string to start with
        public List<Job> _job = new List<Job>(); //Create a list to keep track of jobs (Why do we have to put List<Job> when we are only declaring the data type?)

        public void Display() //Why do we have this again?
        {
        }
    }



    static void Main(string[] args)
    {

        Job test = new Job();
        test._company = "Microsoft";
        test._jobTitle = "Software Engineer";
        test._startYear = 2012;
        test._endYear = 2016;

        test.Display();


    }
}