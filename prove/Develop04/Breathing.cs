public class Breathing : Activity
{
    public Breathing(string name, string desc) : base(name, desc)
    {
        
    }

    public void RunBreathe()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(base.GetDuration());
        DateTime inProgress = start;

        do
        {
            Console.Write("Breathe in...  ");
            base.Countdown(4);
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            base.Countdown(6);
            Console.WriteLine("");
            Console.WriteLine("");
            inProgress = DateTime.Now;
        } while (inProgress < end);
    }
}