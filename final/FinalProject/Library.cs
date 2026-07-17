class Library
{
    private List<FinishedBook> _finishedBooks = new List<FinishedBook>();
    private List<ReadingBook> _readingBooks = new List<ReadingBook>();

    public void StartLibrary()
    {
        Console.Clear();
        Console.Clear();
        Console.CursorVisible = true;
        Console.WriteLine("Welcome to your library.\n");

        DisplaySpinner(2);

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Display Library");
        Console.WriteLine("2. Add Book");
        Console.WriteLine("3. Remove Book");
        Console.WriteLine("4. Save Library");
        Console.WriteLine("5. Load Library");
        Console.WriteLine("6. Exit");
        Console.WriteLine();

        int input = int.Parse(Console.ReadLine());
        //Console.CursorVisible = true;
        if (input == 1)
        {
            DisplayLibrary();
        }
        else if (input == 2)
        {
            AddBook();
            StartLibrary();
        }
        else if (input == 3)
        {
            RemoveBook();
            StartLibrary();
        }
        else if (input == 4)
        {
            SaveLibrary();
        }
        else if (input == 5)
        {
            LoadLibrary();
        }
        else if (input == 6)
        {

        }
        else
        {
            Console.WriteLine("Please type a valid input.");
            DisplaySpinner(1);
            StartLibrary();
        }
    }

    public void DisplayLibrary()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine("What would you like to display?\n");
        Console.WriteLine("1. Full Library");
        Console.WriteLine("2. Finished Books");
        Console.WriteLine("3. Currently Reading");
        // Console.WriteLine("4. Wishlist");
        // Console.WriteLine("5. DNF");

        int input2 = int.Parse(Console.ReadLine());
        if (input2 == 1)
        {
            CheckIfEmpty();

            Console.Clear();
            int _index;

            _index = DisplayReadingBooks();
            DisplayFinishedBooks(_index);

            WaitForEnter();
        } 
        else if (input2 == 2)
        {
            CheckIfEmpty();
            Console.Clear();
            DisplayFinishedBooks(1);

            WaitForEnter();
        }
        else if (input2 == 3)
        {
            CheckIfEmpty();
            Console.Clear();
            DisplayReadingBooks();

            WaitForEnter();
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

    public void RemoveBook()
    {
        Console.WriteLine();
        Console.WriteLine("Which book title would you like to remove?");
        string title = Console.ReadLine();
        Console.WriteLine("Who is the author?");
        string author = Console.ReadLine();

        for (int i = _readingBooks.Count - 1; i >= 0; i--)
        {
            if (_readingBooks[i]._title == title && _readingBooks[i]._author == author)
            {
                _readingBooks.RemoveAt(i);
                Console.WriteLine("Successfully removed this book from your library.");
                DisplaySpinner(2);
                return;
            }
        }

        for (int i = _finishedBooks.Count - 1; i >= 0; i--)
        {
            if (_finishedBooks[i]._title == title && _finishedBooks[i]._author == author)
            {
                _finishedBooks.RemoveAt(i);
                Console.WriteLine("Successfully removed this book from your library.");
                DisplaySpinner(2);
                return;
            }
        }
    }

    public void SaveLibrary()
    {
        Console.WriteLine();
        Console.WriteLine("What file would you like to save it to? (.txt)");
        string _fileName = Console.ReadLine();
        StreamWriter output = new StreamWriter(_fileName);

        foreach (ReadingBook book in _readingBooks)
        {
            output.WriteLine(book.GetSaveString());
        }

        foreach (FinishedBook book in _finishedBooks)
        {
            output.WriteLine(book.GetSaveString());
        }

        output.Close();
        DisplaySpinner(2);
        StartLibrary();
    }

    public void LoadLibrary()
    {
        Console.WriteLine();
        Console.WriteLine("What file would you like to load? (.txt)");
        string _fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts[0] == "Reading")
            {
                ReadingBook book = new ReadingBook(
                    parts[1],
                    parts[2],
                    parts[3],
                    int.Parse(parts[4]),
                    parts[5],
                    int.Parse(parts[6]));

                _readingBooks.Add(book);
            }
            else if (parts[0] == "Finished")
            {
                FinishedBook book = new FinishedBook(
                    parts[1],
                    parts[2],
                    parts[3],
                    int.Parse(parts[4]),
                    parts[5],
                    int.Parse(parts[6]),
                    parts[7]);

                _finishedBooks.Add(book);
            }
        }
        StartLibrary();
    }

    public void DisplaySpinner(int timer)
    {
        Console.CursorVisible = false;
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
        Console.CursorVisible = true;
    }

    public void CheckIfEmpty()
    {
        if (_finishedBooks.Count == 0 && _readingBooks.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Your library is empty.");
            DisplaySpinner(5);
            StartLibrary();
        }
    }

    public int DisplayReadingBooks()
    {
        int _index = 1;

        foreach (ReadingBook book in _readingBooks)
            {
                book.DisplayBook(_index);
                _index++;
            }
        return _index;
    }

    public int DisplayFinishedBooks(int index)
    {
        int _index = index;

        foreach (FinishedBook book in _finishedBooks)
            {
                book.DisplayBook(_index);
                _index++;
            }
        return _index;
    }

    public void WaitForEnter()
    {
        Console.WriteLine("Press ENTER when you would like to exit.");
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.Enter)
        {
            DisplaySpinner(1);
            StartLibrary();
        }
    }
}