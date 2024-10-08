using System.Runtime.InteropServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        foreach (Entry i in _entries)
        {
            i.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter _output = new StreamWriter($"{file}.csv"))
        {
            foreach (Entry i in _entries)
            {
                string entryDate = $"{i._date}";
                string entryPrompt = $"{i._promptText}";
                string entryText = $"{i._entryText}";

                _output.WriteLine($"{entryDate}, {entryPrompt}, {entryText}");
            }
        }

        Console.WriteLine("");
    }

    public void LoadFromFile(string file)
    {
        string fileLoad = $"{file}.csv";
        try
        {
            _entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(fileLoad);
            foreach (string line in lines)
            {
                Entry newEntry = new Entry();

                string[] parts = line.Split(",");

                string newDate = parts[0];
                string newPrompt = parts[1];
                string newText = parts[2];

                newEntry._date = newDate;
                newEntry._promptText = newPrompt;
                newEntry._entryText = newText;

                Console.WriteLine("This is the inserted journal: ");
                Console.WriteLine(newEntry._date);
                Console.WriteLine(newEntry._promptText);
                Console.WriteLine(newEntry._entryText);

                _entries.Add(newEntry);
            }
            
        }
        finally
        {

        }
    }
}