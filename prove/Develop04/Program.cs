using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity myActivity = new BaseActivity("Breathing", "This will help you breathe.");
        // myActivity.StartActivity();
        // myActivity.RunCountDown("breathe in", 5);

        Breathing myBreathing = new Breathing("This will help you breathe better.");
        myBreathing.RunActivity();
    }
}