using System.Data;

abstract class Book
{
    private string _title;
    private string _author;
    private string _genre;
    private int _pageCount;
    private string _comment;
    private DateTime _dateAdded;
    protected string _status;
    private int _rating;
    protected bool _isFinished;

    public Book(string title, string author, string genre, int pageCount)
    {
        _title = title;
        _author = author;
        _genre = genre;
        _pageCount = pageCount;
    }

    public virtual void UpdateStatus()
    {
        Console.WriteLine("Status cannot be updated.");
    }

    public virtual void DisplayBookData(int index)
    {
        Console.Clear();
        if (_status == "Finished")
        {
            Console.WriteLine($"{index}    Date Added: {DateTime.Today}");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Title:      {_title}");
            Console.WriteLine($"Author:     {_author}");
            Console.WriteLine($"Genre:      {_genre}");
            Console.WriteLine($"Pages:      {_pageCount}");
            Console.WriteLine();
            Console.WriteLine($"Status:     {_status}");
            DisplayRating(_rating);
            Console.WriteLine();
            Console.WriteLine($"Comments:\n{_comment}");
            Console.WriteLine("===========================================");
        }
        // Add another one for "Reading" books and make them separate overrided methods in Finished and Reading classes.

    }

    public void DisplayRating(int rating)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int maxStars = 5;

        // 1. Force the rating to stay between 0 and 5 to prevent crashes
        rating = Math.Clamp(rating, 0, maxStars);

        // 2. Generate arrays of characters
        char[] filled = new char[rating];
        Array.Fill(filled, '★');

        char[] empty = new char[maxStars - rating];
        Array.Fill(empty, '☆');

        // 3. Combine them and join them with spaces
        string filledJoined = string.Join(" ", filled);
        string emptyJoined = string.Join(" ", empty);

        // 4. Add an extra space between the filled and empty groups if both exist
        string spacing = (rating > 0 && rating < maxStars) ? " " : "";

        Console.WriteLine($"Rating:     {filledJoined}{spacing}{emptyJoined}");
    }


}