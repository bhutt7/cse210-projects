public abstract class Goal
{
    private string _name;
    private string _description;
    private bool _done = false;

    public Goal(string name, string desc)
    {
        _name = name;
        _description = desc;
    }

    public void Complete()
    {
        _done = true;
    }

    public bool IsDone()
    {
        return _done;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _description;
    }

    public abstract double Update();

    public abstract string Display();

    public abstract string SaveString();
}