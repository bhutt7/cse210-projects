public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nEvent Type: Reception\nRSVP: {_email}";
    }

    public override string ShortDetails()
    {
        return $"Event Type: Reception\nEvent: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}