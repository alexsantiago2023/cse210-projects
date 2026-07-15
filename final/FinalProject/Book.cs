using System.Data;

class Book
{
    private string _title;
    private string _author;
    private string _genre;
    private int _pageCount;
    private string _comment;
    private DateTime _dateAdded;
    private string _status;

    public Book(string title, string author, string genre, int pageCount)
    {
        _title = title;
        _author = author;
        _genre = genre;
        _pageCount = pageCount;
    }

    public Book(string title, string author, string genre)
    {
        _title = title;
        _author = author;
        _genre = genre;
    }

    public void UpdateStatus()
    {
        
    }
}