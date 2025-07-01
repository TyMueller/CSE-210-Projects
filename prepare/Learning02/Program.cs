using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Learning02;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job("Microsoft", "Software Engineer", 2012, 2016); //Constructor

        Resume resume = new Resume();
        resume._name = "Tim Apple";
        resume._job.Add(job1);


        Job job2 = new Job("Google", "AI Researcher", 2017, 2020);

        resume._job.Add(job2);
        resume.Display();
    }
}