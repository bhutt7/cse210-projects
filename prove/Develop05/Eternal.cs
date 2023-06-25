public class Eternal : Goal
{
    private double _value = 50;

    public Eternal(string name, string desc) : base(name, desc)
    {
    }

    public override double Update()
    {
        return _value;
    }

    public override string Display()
    {
        return $"[ ] {GetName()} ({GetDesc()})";
    }

    public override string SaveString()
    {
        return $"Eternal:{GetName()}|{GetDesc()}";
    }
}