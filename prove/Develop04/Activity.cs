public class Activity
{
    private string _name;
    private string _desc;
    private int _duration;

    public Activity(string name, string desc, int seconds)
    {
        _name = name;
        _desc = desc;
        _duration = seconds;
    }

    public string Start()
    {
        return "";
    }

    public string Finish()
    {
        return "";
    }

    public void Countdown(int duration)
    {

    }

    public void Wait()
    {

    }

    public int RandomIndex(List<string> list)
    {
        Random selection = new Random();
        int index = selection.Next(list.Count);
        return index;
    }

    public string GetPrompt(List<string> list)
    {
        return list[RandomIndex(list)];
    }
}