class EternalGoal : Goal
{

    public EternalGoal()
    {
        
    }
    public EternalGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points, isComplete)
    {
        
    }

    public override string GetStringToSave()
    {
        return $"Eternal|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _isComplete = false;
        return _points;
    }
}