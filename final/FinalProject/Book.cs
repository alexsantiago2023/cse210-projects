abstract class Book
{
    public string _title;
    public string _author;
    private string _genre;
    private int _pageCount;
    //private string _comment;
    protected string _dateAdded;
    protected string _status;
    //private int _rating;
    protected bool _isFinished;

    public Book(string title, string author, string genre, int pageCount)
    {
        _title = title;
        _author = author;
        _genre = genre;
        _pageCount = pageCount;
        _dateAdded = DateTime.Today.ToString("MM/dd/yyyy");
    }

    public virtual void UpdateStatus()
    {
        Console.WriteLine("Status cannot be updated.");
    }

    public virtual void DisplayBook(int index)
    {
        {
            Console.WriteLine($"{index}         Date Added: {_dateAdded}");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Title:      {_title}");
            Console.WriteLine($"Author:     {_author}");
            Console.WriteLine($"Genre:      {_genre}");
            Console.WriteLine($"Pages:      {_pageCount}");
        }

    }

    public string DisplayRating(int rating)
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

        return $"Rating:     {filledJoined}{spacing}{emptyJoined}";
    }

    public virtual string GetSaveString()
    {
        return $"{_title}|{_author}|{_genre}|{_pageCount}|{_dateAdded}|";
    }


}