class Library
{
    private List<FinishedBook> _finishedBooks = new List<FinishedBook>();
    private List<ReadingBook> _readingBooks = new List<ReadingBook>();

    public void StartLibrary()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine("Welcome to your library.\n");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Display Library");
        Console.WriteLine("2. Add Book");
        Console.WriteLine("3. Remove Book");
        Console.WriteLine("4. Save Library");
        Console.WriteLine("5. Load Library");
        Console.WriteLine("6. Exit");

        int input = int.Parse(Console.ReadLine());
        Console.CursorVisible = true;
        if (input == 1)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("What would you like to display?\n");
            Console.WriteLine("1. Full Library");
            Console.WriteLine("2. Finished Books");
            Console.WriteLine("3. Currently Reading");
            Console.WriteLine("4. Wishlist");
            Console.WriteLine("5. DNF");

            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 1)
            {
                if (_finishedBooks.Count == 0 && _readingBooks.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Your library is empty.");
                    DisplaySpinner(5);
                    StartLibrary();
                }
                else
                {
                    int _index = 1;
                    foreach (Book book in _readingBooks)
                    {
                        book.DisplayBookData(_index);
                        _index++;
                    }
                    foreach (Book book in _finishedBooks)
                    {
                        book.DisplayBookData(_index);
                        _index++;
                    }
                    
                    Console.WriteLine("Press ENTER when you would like to exit.");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                    {
                        DisplaySpinner(5);
                        StartLibrary();
                    }
                }
            }
        }
        else if (input == 2)
        {
            AddBook();
            StartLibrary();
        }
        else if (input == 3)
        {

        }
        else if (input == 4)
        {

        }
        else if (input == 5)
        {

        }
        else if (input == 6)
        {

        }
        else
        {
            Console.WriteLine("Please type a valid input.");
        }
    }

    public void AddBook()
    {
        Console.Clear();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Genre: ");
        string genre = Console.ReadLine();
        Console.Write("Page Count: ");
        int pageCount = int.Parse(Console.ReadLine());
        // Book newBook = new Book(title, author, genre, pageCount);
        // newBook.UpdateStatus();
        // _books.Add(newBook);
        
        Console.WriteLine("\nWhat type of book is this?");
        Console.WriteLine("1. Reading ");
        Console.WriteLine("2. Finished ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            ReadingBook book = new ReadingBook(title, author, genre, pageCount);
            book.UpdateStatus();

            _readingBooks.Add(book);
        }
        else if (choice == 2)
        {
            FinishedBook book = new FinishedBook(title, author, genre, pageCount);
            book.UpdateStatus();

            _finishedBooks.Add(book);
        }
    }

    public void DeleteBook()
    {

    }

    public void DisplaySpinner(int timer)
    {
        string animationString = "-\\|/";
        int sleepTime = 300;
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(timer);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.Write(" ");
    }
}