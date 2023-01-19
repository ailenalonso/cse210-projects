using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTittle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2013; 
        job1._endYear = 2019; 

        Job job2 = new Job();
        job2._jobTittle = "Engineering Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume theResume = new Resume();
        theResume._name = "Ailen Alonso";

        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);

        theResume.Display();
    }
}