class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // GetWordString - Returns either the word, if not hidden, or the _'s
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach (char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }
}

//Whenever the word is called, make _word the word and make _isHidden false initially.