using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static void PromptUserBirthYear(out int y)
    {
        Console.Write("Please enter the year you were born: ");
        y = int.Parse(Console.ReadLine());
    }

    static double SquareNumber(double x)
    {
        double square = Math.Pow(x, 2);
        return square;
    }

    static void DisplayResult(string name, double square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");

        int age = DateTime.Now.Year - year;
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int birthYear = 0;
        PromptUserBirthYear(out birthYear);
        double square = SquareNumber(favNumber);
        DisplayResult(name, square, birthYear);
    }
}