using System.IO;
public class JournalEntry
{
    //Figure out where you need dates and prompts
    DateTime _date;
    string _dateString;
    string _prompt;
    string _response;
    string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date} - {_prompt}: {_response}");
    }

    public string CreateJournalEntry(string date, string prompt, string response)
    {
        _dateString = date;
        _prompt = prompt;
        _response = response;
        string fullEntry = $"Date: {date} - Prompt: {prompt} - \n{response}";
        return fullEntry;
    }

    public void CreateJournalEntry()
    {
        _dateString = DateTime.Now.ToShortDateString();
        _prompt = _prompts[0];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public string CreateFileSystemString(string entry)
    {
        //List<string> responses = new List<string>();

        string[] parts = entry.Split("- ");
        _dateString = parts[0];
        _prompt = parts[1];
        _response = parts[2];

        string response =  _dateString + '\n' + '\n' + _prompt + "> " + _response;

        return response;
    }

    public string CreateFileSystemStringNew()
    {
       return _dateString + "#" + _prompt + "#" + _response;
    }
}