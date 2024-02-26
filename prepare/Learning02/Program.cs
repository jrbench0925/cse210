using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "CEO";
        job2._startYear = 1999;
        job2._endYear = 2023;

        Resume userResume = new Resume();
        userResume._name = "Bill Gates";

        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        userResume.Display();
    
    }
}