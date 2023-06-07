public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _answers = new List<string>();
    
    public Listing(string name, string desc, int seconds) : base(name, desc, seconds)
    {
        _prompts.Add("a");
        _prompts.Add("b");
        _prompts.Add("n");
        _prompts.Add("s");
        _prompts.Add("d");
        _prompts.Add("f");
    }

    public List<string> GetList()
    {
        return _prompts;
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