using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != magic)
        {
            Console.Write("What's your guess? ");
            string input2 = Console.ReadLine();
            guess = int.Parse(input2);
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}