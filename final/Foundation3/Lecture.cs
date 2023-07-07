public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nEvent Capacity: {_capacity}";
    }

    public override string ShortDetails()
    {
        return $"Event Type: Lecture\nEvent: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}