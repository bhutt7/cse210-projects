using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Save());
            }
        }
    }

    public void LoadJournal(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(date, prompt, response);
            _entries.Add(entry);
        }
    }
}