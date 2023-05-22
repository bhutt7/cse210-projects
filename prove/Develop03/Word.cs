public class Word
{
    private string _word;
    private string _hidden;
    private bool _shown = true;

    public Word(string word)
    {
        _word = word;
        for(int i = 0; i < word.Length; i++)
        {
            _hidden += "_";
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
}