class Listing : BaseActivity
{
    List<string> _prompts = 
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    
    Random random = new Random();

    public Listing(string description) : base("Listing", description)
    {
        
    }

    public void RunActivity()
    {
        StartActivity();
        int pIndex = random.Next(_prompts.Count);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {_prompts[pIndex]} ---");
        RunCountDown("You may begin in: ", 6);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            index++;
        }
        Console.WriteLine($"\nYou listed {index} items!");

        EndActivity();
    }
}