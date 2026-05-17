using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<string> _entries = new List<string>();
    public List<string> _journalEntries = new List<string>();

    List<string> _prompts = new List<string>
    {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?",
         "What did I do today?"};

    public void WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
        string currentTime = DateTime.Now.ToString();

        JournalEntry entry = new JournalEntry();
        _entries.Add(entry.CreateJournalEntry(currentTime, prompt, journalEntry));
        _journalEntries.Add(entry.DisplayForFile(currentTime, prompt, journalEntry));
    }

    public void Display()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry + "\n");
        }
    }

    public void LoadFile()
    {
        Console.Write("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        JournalEntry entry = new JournalEntry();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            _entries.Add(entry.CreateJournalEntry(date, prompt, response));
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        JournalEntry logEntry = new JournalEntry();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (string entry in _journalEntries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }


}