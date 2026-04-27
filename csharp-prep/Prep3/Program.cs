using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Have the user assign a magic number
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNumber = int.Parse(magic);

        //Have the user guess what it is
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}