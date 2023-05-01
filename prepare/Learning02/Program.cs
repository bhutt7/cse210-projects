using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Crime";
        job2._jobTitle = "Joker";
        job2._startYear = 2020;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Braden Huttash";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}