using System.IO;
public class Menu
{
    public void GetUserInput()
    {
        Console.WriteLine("Welcome to the journal program!");
        int choice = 0;

        Journal journal = new Journal();

        do {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                journal.WriteEntry();
            } else if (choice == 2)
            {
                journal.DisplayJournal();
            } else if (choice == 3)
            {
                journal.LoadFile();
            } else if (choice == 4)
            {
                journal.SaveToFile();
            } else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        } while (choice != 5); 
    }
}