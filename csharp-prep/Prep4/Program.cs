using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished. ");
        List<int> numbers = new List<int>();
        int input = 1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            input = int.Parse(x);
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int count = numbers.Count;

        int total = 0;
        foreach (int number in numbers)
        {
            total = total + number;
        }
        Console.WriteLine($"The sum is: {total}");

        float avg = total / (float)count;
        Console.WriteLine($"The average is: {avg}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}