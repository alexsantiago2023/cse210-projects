using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        string answer = "";

        while (answer != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                string _prompt = prompt.GetPrompt();
                Console.WriteLine($"\n{_prompt}");
                Console.Write("> ");
                string _content = Console.ReadLine();
                string _date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(_date, _prompt, _content));
            }
            else if (answer == "2")
            {
                journal.DisplayEntries();
            }
            else if (answer == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (answer == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (answer == "5")
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}