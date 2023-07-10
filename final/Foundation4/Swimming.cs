public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        base.SetTitle("Swimming");
    }

    public override double Distance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62, 1);
    }

    public override double Speed()
    {
        int mins = base.GetMinutes();
        double dist = Distance();
        return Math.Round(dist / mins * 60, 1);
    }

    public override double Pace()
    {
        double speed = Speed();
        return Math.Round(60 / speed, 1);
    }
}