public class Simple : Goal
{
    private double _value = 100;

    public Simple(string name, string desc) : base(name, desc)
    {
    }

    public override double Update()
    {
        Complete();
        return _value;
    }

    public override string Display()
    {
        string status = " ";
        if (IsDone())
        {
            status = "X";
        }

        return $"[{status}] {GetName()} ({GetDesc()})";
    }

    public override string SaveString()
    {
        return $"Simple:{GetName()}|{GetDesc()}|{IsDone()}";
    }
}