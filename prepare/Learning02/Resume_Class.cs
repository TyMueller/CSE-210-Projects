using System;

namespace Learning02;

public class Resume
{
    public string _name; //Empty string by default
    public List<Job> _job = new List<Job>();

    public void Display()
    {
        foreach (Job i in _job)
        {
            i.Display();
        }
    }
    }
