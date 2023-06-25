public class UserGoals
{
    private List<Goal> _goals = new List<Goal>();
    private double _score = 0;
    private int _level = 1;

    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }

    public void Target(int goal)
    {
        UpdateScore(_goals[goal - 1].Update());
    }

    public void UpdateScore(double value)
    {
        Console.WriteLine($"Congratulations! You have earned {value} points!");
        _score += value;
        double mod = (_level * _level * 100) - (_level * 100);
        double threshold = _level * 1000 + mod;
        if (_score >= threshold)
        {
            _level += 1;
            Console.WriteLine("You leveled up!");
        }
    }

    public double NextLevel()
    {
        double mod = (_level * _level * 100) - (_level * 100);
        double threshold = _level * 1000 + mod;
        double nextLevel = threshold - _score;
        return nextLevel;
    }

    public double GetScore()
    {
        return _score;
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetListLength()
    {
        return _goals.Count;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine($"{_score}");
            outputFile.WriteLine($"{_level}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveString());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        _score = double.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        _level = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] objects = line.Split(":");
            string type = objects[0];
            
            string[] parts = objects[1].Split("|");

            string name = parts[0];
            string desc = parts[1];

            switch (type)
            {
                case "Simple":
                    Simple simple = new Simple(name, desc);
                    if (parts[2] == "True")
                    {
                        simple.Complete();
                    }
                    _goals.Add(simple);
                    break;
                case "Eternal":
                    Eternal eternal = new Eternal(name, desc);
                    _goals.Add(eternal);
                    break;
                case "Checklist":
                    Checklist checklist = new Checklist(name, desc, int.Parse(parts[2]));
                    checklist.SetCompletions(int.Parse(parts[3]));
                    if (parts[3] == parts[2])
                    {
                        checklist.Complete();
                    }
                    _goals.Add(checklist);
                    break;
            }
        }
    }

    public string Display()
    {
        string list = "";
        for (int i = 0; i < _goals.Count; i++)
        {
            list += $"{i + 1}. {_goals[i].Display()}\n";
        }
        return list;
    }

    public string DisplayNames()
    {
        string list = "";
        for (int i = 0; i < _goals.Count; i++)
        {
            list += $"{i + 1}. {_goals[i].GetName()}\n";
        }
        return list;
    }
}