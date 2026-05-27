using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        //Scripture myScripture = new Scripture();
        //myScripture.Display();

        Word myWord = new Word("Hello");
        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }
    }
}