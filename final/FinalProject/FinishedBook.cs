class FinishedBook : Book
{
    private string _comment;
    private int _rating;

    public FinishedBook(string title, string author, string genre, int pageCount)
    : base(title, author, genre, pageCount)
    {
    
    }

    public FinishedBook(string title, string author, string genre, int pageCount, string dateAdded, int rating, string comment)
    : base(title, author, genre, pageCount)
    {
        _rating = rating;
        _comment = comment;
        _dateAdded = dateAdded;
        _status = "Finished";
    }

    public override void UpdateStatus()
    {
        _status = "Finished";
        _isFinished = true;

        Console.Write("Rating (out of 5 stars): ");
        _rating = int.Parse(Console.ReadLine());
        
        Console.Write("Comments: ");
        _comment = Console.ReadLine();
    }
    
    public override void DisplayBook(int index)
    {
        base.DisplayBook(index);
        Console.WriteLine();
        Console.WriteLine($"Status:     {_status}");
        Console.WriteLine(DisplayRating(_rating));
        Console.WriteLine();
        Console.WriteLine($"Comments:\n{_comment}");
        Console.WriteLine("===========================================");
    }

    public override string GetSaveString()
    {
        return "Finished|" + base.GetSaveString() + $"{_rating}|{_comment}";
    }
}