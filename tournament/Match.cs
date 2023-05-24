public class Match
{
    private Team _team1;
    private Team _team2;

    public Match(Team t1, Team t2)
    {
        _team1 = t1;
        _team2 = t2;
    }

    public void Winner()
    {
        Random win = new Random();
        int winner = win.Next(0,1);
        if (winner == 0)
        {
            Console.WriteLine(_team1);
        }
        else
        {
            Console.WriteLine(_team2);
        }
    }
}