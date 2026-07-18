class SimpleGoal : Goal
{

    public SimpleGoal()
    {
        
    }
    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points, isComplete)
    {
        
    }

    public override string GetStringToSave()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
    
}