public class Running : Activity
{
    private double _distance;
    
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
        base.SetTitle("Running");
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        int mins = base.GetMinutes();
        return Math.Round(_distance / mins * 60, 1);
    }

    public override double Pace()
    {
        int mins = base.GetMinutes();
        return Math.Round(mins / _distance, 1);
    }
}