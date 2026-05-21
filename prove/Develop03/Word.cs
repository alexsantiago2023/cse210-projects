class Word
{
    private string _word;
    private string _hidden;
    private bool _isHidden = false;

    public void GetWord(string word)
    {
        _word = word;
        Hide();
    }

    private void Hide()
    {
        foreach (char x in _word)
        {
            _hidden += '_';
        }
    }

    public string SetWord()
    {
        return _hidden;
    }
}