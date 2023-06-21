public abstract class Goal
{
    private string _description;
    private bool _done = false;

    public Goal(string desc)
    {
        _description = desc;
    }

    public bool IsDone()
    {
        return _done;
    }

    public abstract int Update()
    {
    }
}