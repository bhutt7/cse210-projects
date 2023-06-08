public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    public Reflection(string name, string desc) : base(name, desc)
    {
        _prompts.Add("Think of a time when you stepped out of your comfort zone.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you achieved a personal goal.");
        _prompts.Add("Think of a time when you served someone else.");

        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("How did you get started?");
    }

    public void RunReflect()
    {
        string prompt = base.GetPrompt(_prompts);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---| {prompt} |---");
        Console.WriteLine("");
        Console.WriteLine("When you have an experience in mind, press [Enter] to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions in relation to this experience.");
        Console.Write("You will begin in: ");
        base.Countdown(5);
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(base.GetDuration());
        DateTime inProgress = start;

        do
        {
            Console.WriteLine($"> {GetQuestion()}");
            base.Wait(14);
            inProgress = DateTime.Now;
        } while (inProgress < end);

        Console.WriteLine("");
    }

    public string GetQuestion()
    {
        if(_questions.Count == 0)
        {
            foreach(string q in _usedQuestions)
            {
                _questions.Add(q);
            }
            _usedQuestions.Clear();
        }

        int index = base.RandomIndex(_questions);
        string question =  _questions[index];
        _usedQuestions.Add(question);
        _questions.RemoveAt(index);
        return question;
    }
}