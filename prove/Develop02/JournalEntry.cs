using System.IO;
public class JournalEntry
{
    DateTime _date;
    string _dateString;
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
        string fullEntry = $"Date: {date} - Prompt: {prompt} \n{response}";
        return fullEntry;
    }

    public void CreateJournalEntry()
    {
        
    }

    public string CreateFileSystemString(string entry)
    {
        //List<string> responses = new List<string>();

        string[] parts = entry.Split(' ');
        _dateString = parts[0] + " " + parts[1];
        _prompt = parts[5];
        _response = parts[6];

        string response =  _dateString + '\n' + '\n' + _prompt + '\n' + _response;

        return response;
    }
}