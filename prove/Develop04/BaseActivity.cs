class BaseActivity : Menu
{
    private string _name;
    private string _description;
    protected int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplaySpinner(int timer)
    {
        string animationString = "-\\|/";
        int sleepTime = 300;
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(timer);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.Write(" ");
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow many seconds would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready... ");
        DisplaySpinner(3);
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}");
        while (duration >= 0)
        {
            Console.Write($"{duration--,1}");
            Thread.Sleep(1000);
            Console.Write("\b");

        }
        Console.Write(" ");
        Console.WriteLine("");
    }

    public void EndActivity()
    {
        Console.CursorVisible = false;
        Console.WriteLine("\nWell Done!");
        DisplaySpinner(3);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        DisplaySpinner(5);

        Console.CursorVisible = true;
        DisplayMenu();
    }
}