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
        for (int i = 0; i < 30; i++)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }
}