using System;
using System.Dynamic;
using System.Globalization;
using System.Net.NetworkInformation;
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
        string num_before = Console.ReadLine();
        int num = int.Parse(num_before);
        return num;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string year = Console.ReadLine();
        birthYear = int.Parse(year);
    }

    static int SquareNumber(int x)
    {
        int square = x * x;
        return square;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
        Console.WriteLine($"{name}, you will turn {2025 - year} years old this year.");
    }

    public static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }
}