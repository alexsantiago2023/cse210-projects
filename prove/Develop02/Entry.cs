public class Entry
{
    public string _content;
    public string _date;
    public string _prompt;

    public Entry(string date, string prompt, string content)
    {
        _content = content;
        _date = date;
        _prompt = prompt;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_content);
        Console.WriteLine();
    }
}

