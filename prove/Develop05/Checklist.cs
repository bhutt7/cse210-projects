public class Checklist : Goal
{
    private double _value = 50;
    private double _bonus = 500;
    private int _numCompletions = 0;
    private int _targetCompletions;

    public Checklist(string name, string desc, int target) : base(name, desc)
    {
        _targetCompletions = target;
    }

    public void SetCompletions(int value)
    {
        _numCompletions = value;
    }

    public override double Update()
    {
        _numCompletions += 1;
        if (_numCompletions == _targetCompletions)
        {
            Complete();
            _value += _bonus;
        }
        return _value;
    }

    public override string Display()
    {
        string status = " ";
        if (IsDone())
        {
            status = "X";
        }
        return $"[{status}] {GetName()} ({GetDesc()}) -- Currently completed: {_numCompletions}/{_targetCompletions}";
    }

    public override string SaveString()
    {
        return $"Checklist:{GetName()}|{GetDesc()}|{_targetCompletions}|{_numCompletions}";
    }
}