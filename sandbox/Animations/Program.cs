using System;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        int sleepTime = 100;
        Console.Clear();
        Console.CursorVisible = false;

        /*for (int i = 0; i < 10; i++)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }*/

        string animationString = "-\\|/";
        int index = 0;

        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(5);
        Console.WriteLine(now.ToString());

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.WriteLine(endTime.ToString());

        Console.CursorVisible = true;

        int count = 15;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{count--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

}