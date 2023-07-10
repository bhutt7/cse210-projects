public class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        base.SetTitle("Cycling");
    }

    public override double Distance()
    {
        int mins = base.GetMinutes();
        return Math.Round(_speed / 60 * mins, 1);
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return Math.Round(60 / _speed, 1);
    }
}