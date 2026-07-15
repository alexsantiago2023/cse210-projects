class Library
{
    public void StartLibrary()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine("Welcome to your library.\n");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Display Library");
        Console.WriteLine("2. Add Books");
        Console.WriteLine("3. Remove Books");
        Console.WriteLine("4. Save Library");
        Console.WriteLine("5. Load Library");
        Console.WriteLine("6. Exit");

        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("What would you like to display?\n");
            Console.WriteLine("1. Full Library");
            Console.WriteLine("2. Finsihed Books");
            Console.WriteLine("3. Display Library");
            Console.WriteLine("4. Wishlist");
            Console.WriteLine("5. DNF");

            int input2 = int.Parse(Console.ReadLine());
        }
        else if (input == 2)
        {

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
        
    }

    public void DeleteBook()
    {
        
    }
}