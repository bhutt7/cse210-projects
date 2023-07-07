public abstract class Event
{
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"Event: {_title}\nDescription: {_desc}\nWhen Is It: {_date}, {_time}\nAddress:\n{_address.Display()}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract string FullDetails();

    public abstract string ShortDetails();
}