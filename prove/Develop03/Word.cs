public class Word
{
    private string _word;
    private string _hidden;
    private bool _shown = true;

    public Word(string word)
    {
        _word = word;
        int index = word.Length - 1;
        if (Char.IsLetter(_word[index]))
        {
            for(int i = 0; i < word.Length; i++)
            {
                _hidden += "_";
            }
        }
        else
        {
            for(int i = 1; i < word.Length; i++)
            {
                _hidden += "_";
            }
            _hidden += _word[index];
        }
    }

    public string Display()
    {
        if(_shown)
        {
            return _word;
        }
        else
        {
            return _hidden;
        }
    }

    public void Hide()
    {
        _shown = false;
    }

    public bool IsHidden()
    {
        if (_shown)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}