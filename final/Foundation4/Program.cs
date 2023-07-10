using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("07 July 2023", 30, 3);
        Cycling cycle = new Cycling("08 July 2023", 50, 14);
        Swimming swim = new Swimming("09 July 2023", 15, 50);

        List<Activity> exercises = new List<Activity>();
        exercises.Add(run);
        exercises.Add(cycle);
        exercises.Add(swim);

        Console.WriteLine("----------------------------------------------------------------------------------------------------");

        foreach (Activity exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}