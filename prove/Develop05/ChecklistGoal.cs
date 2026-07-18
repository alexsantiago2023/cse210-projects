class ChecklistGoal : Goal
{
    private int _totalTimes;
    private int _numberComplete = 0;
    private int _bonus;

    public ChecklistGoal()
    {
        
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int totalTimes, int numberComplete, int bonus)
    : base(name, description, points, isComplete)
    {
        _totalTimes = totalTimes;
        _numberComplete = numberComplete;
        _bonus = bonus;
    }

    public override void GetDetails()
    {
        base.GetDetails();
        Console.Write("How many times does it need to be accomplished for a bonus? ");
        _totalTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());    
    }

    public override string DisplayGoal(int index)
    {
        return $"{base.DisplayGoal(index)}" + $" -- Currently completed: {_numberComplete}/{_totalTimes}";
    }

    public override string GetStringToSave()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_isComplete}|{_totalTimes}|{_numberComplete}|{_bonus}";
    }

    public override int CompleteGoal()
    {
        _numberComplete ++;
        int total = _points;

        if (_numberComplete == _totalTimes)
        {
            total += _bonus;
            _isComplete = true;
        }

        Console.WriteLine($"Congratulations! You have earned {total} points!");
        return total;
    }
}