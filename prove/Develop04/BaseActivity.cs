class BaseActivity
{
    private string _name;
    private string _description;
    private string _endMessage;
    private int _duration;
    private DateTime _endTime;
    protected int _activityChoice;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplaySpinner()
    {
        
    }

    public void Wait()
    {
        
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);

        Console.Write("\nHow many seconds for this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}:");
        while (duration >= 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine("");
    }  
}