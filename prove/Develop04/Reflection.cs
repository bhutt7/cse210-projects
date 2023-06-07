public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(string name, string desc, int seconds) : base(name, desc, seconds)
    {
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");
        _prompts.Add("");

        _questions.Add("");
        _questions.Add("");
        _questions.Add("");
        _questions.Add("");
        _questions.Add("");
        _questions.Add("");
    }

    public string GetQuestion()
    {
        return _questions[RandomIndex(_questions)];
    }
}