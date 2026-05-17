using System.IO;
public class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    public string DisplayForFile(string date, string prompt, string response)
    {
        return $"Date: {date}|Prompt: {prompt}|{response}";
    }

    public string CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        string fullEntry = $"Date: {date} - Prompt: {prompt} \n{response}";
        return fullEntry;
    }

    public string CreateFileSystemString(string entry)
    {
        //List<string> responses = new List<string>();

        string[] parts = entry.Split('|');
        _date = parts[0];
        _prompt = parts[1];
        _response = parts[2];

        string response = _date + '\n' + '\n' + _prompt + '\n' + _response + '\n';

        return response;
    }
}