public class Scripture
{
    private string _text;
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
        _words = new List<Word>();
    }
}