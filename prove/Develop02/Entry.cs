public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        
    }

    public string Display()
    {
        return $"{_date}\n{_prompt}\n{_response}\n----------------------------------------";
    }

    public string Save()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}