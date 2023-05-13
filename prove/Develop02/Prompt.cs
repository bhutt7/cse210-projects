public class Prompt
{
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
        var random = new Random();
        var randomNumber = random.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        _prompts.RemoveAt(randomNumber);
        return prompt;
    }
    
    public bool IsEmpty()
    {
        if (_prompts.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}