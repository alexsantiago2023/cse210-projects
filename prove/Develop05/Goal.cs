using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations.Schema;

class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal()
    {
        
    }

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public virtual void GetDetails()
    {
        Console.Write("What is the name of your Goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("How many points is it worth? ");
        _points = int. Parse(Console.ReadLine());
    }

    public virtual string DisplayGoal(int index)
    {
        return $"{index} {ToggleComplete()} {_name} ({_description})";
    }

    public virtual string GetStringToSave()
    {
        return $"{_name}|{_description}|{_points}|{_isComplete}";
    }

    public virtual int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _isComplete = true;
        return _points;
    }

    public string ToggleComplete()
    {
        if (_isComplete)
        {
            return "[x]";
        }
        else
        {
            return "[ ]";
        }
    }
}