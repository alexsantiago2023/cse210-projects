using System.CodeDom.Compiler;

class Scripture
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _content;
    private string _reference;
    List<Word> _words = new List<Word>();
    private Random random = new Random();

    public Scripture(string book, int chapter, int startVerse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _content = content;

        Reference tempRef = new Reference(_book, _chapter, _startVerse);
        _reference = tempRef.GetScriptureReference();

        foreach (string word in content.Split(' '))
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
            //tempWord.Hide();
        }
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

        foreach (string word in content.Split(' '))
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
            //tempWord.Hide();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("\n" + _reference);
        foreach (Word word in _words)
        {
            Console.Write(word.GetWordString() + " ");
        }
        Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish:");
    }

    public bool HiddenMax()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords(int amt)
    {
        //I got this _hiddenCount syntax from AI but I didn't know how else to do it.
        int _hiddenCount = _words.Count(w => !w.IsHidden());
        if (_hiddenCount < amt)
        {
            amt = _hiddenCount;
        }

        for (int i = 0; i < amt; i++){

            int index;
            do
            {
                index = random.Next(0, _words.Count);   
            } 
            while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }
}