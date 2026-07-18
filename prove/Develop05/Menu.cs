using System.Security.Cryptography.X509Certificates;
using System.IO;

class Menu
{
    List<Goal> _goals = new List<Goal>();
    private bool _isRunning = true;
    private int _pointTotal = 0;

    public void Run()
    {
        do 
        {
            DisplayMenu();
        } 
        while (_isRunning);
    }

    public void DisplayMenu()
    {
        Points();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            GoalMenu();
        }
        else if (choice == 2)
        {
            ListGoals();
        }
        else if (choice == 3)
        {
            SaveGoals();
        }
        else if (choice == 4)
        {
            LoadGoals();
        }
        else if (choice == 5)
        {
            RecordEvent();
        }
        else
        {
            _isRunning = false;
        }
    }

    public void Points()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_pointTotal} points.");
        Console.WriteLine();
    }

    public void GoalMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SimpleGoal goal = new SimpleGoal();
            goal.GetDetails();
            _goals.Add(goal);
        } 
        else if (choice == 2)
        {
            EternalGoal goal = new EternalGoal();
            goal.GetDetails();
            _goals.Add(goal);
        }
        else if (choice == 3)
        {
            ChecklistGoal goal = new ChecklistGoal();
            goal.GetDetails();
            _goals.Add(goal);
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals are:");

        int index = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.DisplayGoal(index));
            index++;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goals? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_pointTotal);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringToSave());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("What is the file name you want to load? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _pointTotal = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])
                );
                _goals.Add(goal);
            }
            else if (parts[0] == "Eternal")
            {
                EternalGoal goal = new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])
                );
                _goals.Add(goal);
            }
            else if (parts[0] == "Checklist")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6]),
                    int.Parse(parts[7])
                );
                _goals.Add(goal);
            }
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int input = int.Parse(Console.ReadLine());

        _pointTotal += _goals[input - 1].CompleteGoal();
        Console.WriteLine($"You now have {_pointTotal} points.");
    }
}