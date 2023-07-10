public abstract class Activity
{
    private string _date;
    private string _title;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetSummary()
    {
        return $"{_date} {_title} ({_minutes} min) --- Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();
}