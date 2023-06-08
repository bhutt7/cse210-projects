public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _answers = new List<string>();
    
    public Listing(string name, string desc) : base(name, desc)
    {
        _prompts.Add("Where do you want to see improvement in your life?");
        _prompts.Add("What challenges have you overcome recently?");
        _prompts.Add("What are your greatest accomplishments?");
        _prompts.Add("When have you felt loved lately?");
        _prompts.Add("Who do you look up to?");
        _prompts.Add("What makes you smile?");
    }

    public void RunList()
    {
        string prompt = base.GetPrompt(_prompts);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---| {prompt} |---");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        base.Countdown(5);
        Console.WriteLine("");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(base.GetDuration());
        DateTime inProgress = start;
        string answer = "";
        
        do
        {
            Console.Write("> ");
            answer = Console.ReadLine();
            AppendAnswer(answer);
            inProgress = DateTime.Now;
        } while (inProgress < end);

        Console.WriteLine("");
        Console.WriteLine($"You listed {CountAnswers()} items.");
        Console.WriteLine("");
    }

    public void AppendAnswer(string answer)
    {
        _answers.Add(answer);
    }

    public int CountAnswers()
    {
        return _answers.Count;
    }
}