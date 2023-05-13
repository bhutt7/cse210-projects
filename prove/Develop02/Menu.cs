public class Menu
{
    private Journal _journal;
    private Prompt _prompts = new Prompt();

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void Display()
    {
        string choice = "";
        string filename = "";
        string[] options = {"N","V","S","L","Q"};
        while (choice != "Q")
        {
            while (options.Contains(choice)==false)
            {
                Console.Write("[N]ew Entry\n[V]iew Journal\n[S]ave Journal\n[L]oad Journal\n[Q]uit\nPlease choose one of the options above: ");
                choice = Console.ReadLine() ?? String.Empty;
                choice = choice.ToUpper();
            }
            switch (choice)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "N":
                    if(_prompts.IsEmpty())
                    {
                        Console.WriteLine("You have answered all prompts today. Go and have a great tomorrow!");
                    }
                    else
                    {
                        Console.WriteLine("What is the date?");
                        string date = Console.ReadLine();
                        string prompt = _prompts.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();
                        Entry entry = new Entry(date, prompt, response);
                        _journal.AddEntry(entry);
                    }
                    break;
                case "V":
                    _journal.Display();
                    break;
                case "S":
                    Console.Write("Please enter the name of the file to save to: ");
                    filename = Console.ReadLine();
                    _journal.SaveJournal(filename);
                    break;
                case "L":
                    Console.Write("Please enter the name of the file to be loaded: ");
                    filename = Console.ReadLine();
                    _journal.LoadJournal(filename);
                    break;
            }
            choice = "";
            filename = "";
        }
    }
}