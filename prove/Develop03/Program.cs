using System;
using System.Net.Quic;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        List<Scripture> scriptures = new List<Scripture>();
        Scripture sr = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        scriptures.Add(sr);
        
        string input = "";

        while (true)
        {
            sr.Display();
            input = Console.ReadLine();
            if (input == "")
            {
                sr.HideWords(3);
                
            } else if (input == "quit")
            {
                return;
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            
            if (sr.HiddenMax())
            {
                sr.Display();
                break;
            }
        }
    }
}