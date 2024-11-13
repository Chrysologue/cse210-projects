using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating instance of Job class
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Creating the instance of Resume class and assigning it to variable myResume.
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();

    }
}