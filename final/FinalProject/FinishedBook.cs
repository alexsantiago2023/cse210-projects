class FinishedBook : Book
{
    private string _comment;
    private int _rating;

    public FinishedBook(string title, string author, string genre, int pageCount)
    : base(title, author, genre, pageCount)
    {
    
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
}