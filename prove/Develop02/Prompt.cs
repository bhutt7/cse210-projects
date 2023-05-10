public class Prompt
{
    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("What was your greatest accomplishment today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("Did you encounter any difficult situations, and how did you overcome them?");
        _prompts.Add("What is something you want to achieve?");
        _prompts.Add("What is something you want to change about yourself?");
    }

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == 5)
        {
            _prompts = _usedPrompts;
            _usedPrompts.Clear();
        }
        var random = new Random();
        var randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        _usedPrompts.Add(prompt);
        _prompts.RemoveAt(randomNumber);
        return prompt;
    }
}