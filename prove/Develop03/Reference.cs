public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = 0;
    }
    
    public Reference(string book, int chapter, int first, int last)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = first;
        _lastVerse = last;
    }

    public string Display()
    {
        if(_lastVerse == 0)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
    }
}