using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if(!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {Points} points");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name}|{Description}|{Points}|{_isComplete}";
    }
}