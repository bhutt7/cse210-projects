using System;

// Exceeding Requirements: I added a leveling system based on how many oints are collected. The first threshold for leveling up is 1000 points (Level 2), then each successive threshold is 200 points higher, so the Level 3 comes after 1200 additional points (2200 total), then Level 4 after 1400 additional points (3600 total), and so on.

class Program
{
    static void Main(string[] args)
    {
        UserGoals goals = new UserGoals();
        string choice;
        string type;
        string name;
        string desc;
        int target;
        string filename;
        int update;
        do
        {
            Console.WriteLine();
            Console.WriteLine($"You are a Level {goals.GetLevel()} Goal Achiever.");
            Console.WriteLine($"You have {goals.GetScore()} points.");
            Console.WriteLine($"You need {goals.NextLevel()} points for next level.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    type = Console.ReadLine();
                    string[] options = {"1", "2","3"};
                    if (options.Contains(type))
                    {
                        switch (type)
                        {
                            case "1":
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of this goal? ");
                                desc = Console.ReadLine();
                                Simple simple = new Simple(name, desc);
                                goals.AddGoal(simple);
                                break;
                            case "2":
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of this goal? ");
                                desc = Console.ReadLine();
                                Eternal eternal = new Eternal(name, desc);
                                goals.AddGoal(eternal);
                                break;
                            case "3":
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of this goal? ");
                                desc = Console.ReadLine();
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                target = int.Parse(Console.ReadLine());
                                Checklist checklist = new Checklist(name, desc, target);
                                goals.AddGoal(checklist);
                                break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Your goals are:");
                    Console.WriteLine(goals.Display());
                    break;
                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    goals.SaveGoals(filename);
                    break;
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    goals.LoadGoals(filename);
                    break;
                case "5":
                    Console.WriteLine("Your goals are:");
                    Console.WriteLine(goals.DisplayNames());
                    Console.Write("Which goal did you accomplish? ");
                    update = int.Parse(Console.ReadLine());
                    goals.Target(update);
                    break;
                default:
                    Console.Clear();
                    break;
            }
        } while (choice != "6");
    }
}