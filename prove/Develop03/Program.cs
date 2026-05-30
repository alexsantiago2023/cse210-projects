using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<Scripture> scriptures = new List<Scripture>();
        Scripture sr = new Scripture("John", 3, 16, "For God so loved the world");

        scriptures.Add(sr);
        foreach (Scripture s in scriptures)
        {
            s.ConvertToWords(_content);
            s.Display();
        }
    }
}