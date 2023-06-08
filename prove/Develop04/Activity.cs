public class Activity
{
    private string _name;
    private string _desc;
    private int _duration;

    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready");
        Wait(4);
        Console.WriteLine("");
        Console.WriteLine("");
    }

    public void Finish()
    {
        Console.WriteLine("Well done.");
        Wait(4);
        Console.WriteLine("");
        Console.WriteLine($"You just completed your {_duration} second {_name} Activity.");
        Wait(4);
        Console.Clear();
    }

    public void Countdown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Wait(int seconds)
    {
        int iterations = seconds / 2;
        for(int i = iterations; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }

    public int RandomIndex(List<string> list)
    {
        Random selection = new Random();
        int index = selection.Next(list.Count);
        return index;
    }

    public string GetPrompt(List<string> list)
    {
        return list[RandomIndex(list)];
    }

    public int GetDuration()
    {
        return _duration;
    }
}