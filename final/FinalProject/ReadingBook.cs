class ReadingBook : Book
{
    private int _currentPage;

    public ReadingBook(string title, string author, string genre, int pageCount)
    : base(title, author, genre, pageCount)
    {
        
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
        int _currentPage = int.Parse(Console.ReadLine());
    }
}