using System.IO;
public class JournalEntry
{
    DateTime _date;
    string _prompt;
    string _response;

    

    public void Display()
    {

    }

    public string CreateJournalEntry(DateTime date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        string fullEntry = $"Date: {date} - Prompt: {prompt}\n{response}";
        return fullEntry;
    }

    public void CreateJournalEntry()
    {
        
    }

    public void CreateFileSystemString()
    {

    }
}