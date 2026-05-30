using System.CodeDom.Compiler;

class Scripture
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _content;
    private string _reference;

    public Scripture(string book, int chapter, int startVerse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _content = content;

        Reference tempRef = new Reference(_book, _chapter, _startVerse);
        _reference = tempRef.GetScriptureReference();
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _content = content;

        Reference tempRef = new Reference(_book, _chapter, _startVerse, _endVerse);
        _reference = tempRef.GetScriptureReference();
    }

    public List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            Word tempWord = new Word(word);
            words.Add(tempWord);
            tempWord.Hide();
        }
        return words;
    }

    public void Display()
    {
        Console.WriteLine(_reference);
    }
}