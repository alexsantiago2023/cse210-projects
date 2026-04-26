using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        string gradeLetter;

        int gradeNumber = int.Parse(grade);
        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int num = gradeNumber % 10;
        string sign;
        if (num >= 7)
        {
            sign = "+";
        }
        else if (num <= 3)
        {
            sign = "-";
        } else
        {
            sign = "";
        }

        Console.WriteLine($"\nYour grade is: {gradeLetter}{sign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You didn't quite pass. Try again and next time you'll do better!");
        }

    }
}