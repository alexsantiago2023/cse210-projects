class Reflecting : BaseActivity
{
    List<string> _prompts = 
    [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    List<string> _questions = 
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    Random random = new Random();

    public Reflecting(string description) : base("Reflecting", description)
    {
        
    }

    public void RunActivty()
    {
        StartActivity();
        int pIndex = random.Next(_prompts.Count);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {_prompts[pIndex]} ---");
        Console.WriteLine("\nWhen you have something in mind, press ENTER to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDown("You may begin in: ", 5);

        DisplayQuestions();
        EndActivity();

    }

    public void DisplayQuestions()
    {
        Console.Clear();
        Console.CursorVisible = false;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int qIndex = random.Next(_questions.Count);
            Console.Write($"> {_questions[qIndex]} ");
            DisplaySpinner(8);
            Console.WriteLine();
        }
        Console.CursorVisible = true;
    }
}