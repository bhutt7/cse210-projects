public class Scripture
{
    private string _text;
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _text = text;
        _reference = reference;
        _words = new List<Word>();
        string[] parts = _text.Split(" ");
        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.Write($"{_reference.Display()} ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.Display()} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void HideRandom()
    {
        Random hider = new Random();
        int hideCount = 0;
        int index;
        int remainder = 0;
        foreach (Word word in _words)
        {
            if (word.IsShown())
            {
                remainder += 1;
            }
        }
        
        if (remainder >= 3)
        {
            while (hideCount < 3)
            {    
                index = hider.Next(_words.Count);
                if (_words[index].IsShown())
                {
                    _words[index].Hide();
                    hideCount += 1;
                }
            }
        }
        else
        {
            foreach (Word word in _words)
            {
                if (word.IsShown())
                {
                    word.Hide();
                }
            }
        }

    }

    public bool IsComplete()
    {
        int shown = 0;
        foreach (Word word in _words)
        {
            if(word.IsShown())
            {
                shown += 1;
            }
        }
        
        if (shown == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}