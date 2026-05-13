using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<string> _entries = new List<string>();

    List<string> _prompts = new List<string>
    {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?"};

    public void WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
        DateTime currentTime = DateTime.Now;

        JournalEntry entry = new JournalEntry();
        _entries.Add(entry.CreateJournalEntry(currentTime, prompt, journalEntry));        
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
        
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
        }
    }

    
}