class ReadingBook : Book
{
    private int _currentPage;

    public ReadingBook(string title, string author, string genre, int pageCount)
    : base(title, author, genre, pageCount)
    {
        
    }

    public ReadingBook(string title, string author, string genre, int pageCount, string dateAdded, int currentPage)
    : base(title, author, genre, pageCount)
    {
        _currentPage = currentPage;
        _status = "Reading";
        _dateAdded = dateAdded;
    }

    public bool IsFinishedQuestion()
    {
        Console.Write("Have you finished this book? ");
        string input = Console.ReadLine().ToLower();

        if (input.ToLower() == "yes")
        {
            return true;
        } 
        else
        {
            return false;
        }
    }

    public override void UpdateStatus()
    {
        _status = "Reading";
        _isFinished = false;

        Console.Write("Current page: ");
        _currentPage = int.Parse(Console.ReadLine());
    }

    public override void DisplayBook(int index)
    {
        base.DisplayBook(index);
        Console.WriteLine();
        Console.WriteLine($"Status:     {_status}");
        Console.WriteLine($"Current page: {_currentPage}");
        Console.WriteLine("===========================================");
    }
    public override string GetSaveString()
    {
        return "Reading|" + base.GetSaveString() + $"{_currentPage}";
    }
}