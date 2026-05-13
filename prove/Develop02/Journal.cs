using System.Security.Cryptography.X509Certificates;

public class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
        string currentTime = DateTime.Now.ToShortDateString();

        JournalEntry entry = new JournalEntry();
        _entries.Add(entry.CreateJournalEntry(currentTime, prompt, journalEntry));
    }

    public void AddEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void LoadFile()
    {

    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        JournalEntry logEntry = new JournalEntry();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(logEntry.CreateFileSystemString(entry));
            }
        }
    }


}