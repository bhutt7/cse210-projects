public class Gathering : Event
{
    private string _weather;

    public Gathering(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nEvent Type: Gathering\nExpected Weather: {_weather}";
    }

    public override string ShortDetails()
    {
        return $"Event Type: Gathering\nEvent: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}