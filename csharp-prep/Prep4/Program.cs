using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        List<float> Numbers = new List<float>();
        float number = -1;
        //Create a do while loop for the user to input numbers.
        do
        {
            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            number = float.Parse(x);
            Numbers.Add(number);
        } while (number != 0);

        //Create a foreach loop that finds the sum, then the average
        float total = 0;
        foreach (float num in Numbers)
        {
            total += num;
        }
        float average = total / (Numbers.Count - 1);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");

        //Create a foreach loop with an if statement to find the largest number
        float largest = 0;
        foreach (float num in Numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}