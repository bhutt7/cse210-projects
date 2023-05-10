public class Entry
{
    private DateTime _currentDateTime;
    private string _prompt;
    private string _response;

    public Entry()
    {
        _currentDateTime = DateTime.Now;
        _prompt = ;
        
    }

    public string Display()
    {
        return $"{_currentDateTime}\n{_prompt}\n{_response}"
    }
}