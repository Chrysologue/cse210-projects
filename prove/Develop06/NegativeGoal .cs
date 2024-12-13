using System;
public class NegativeGoal : Goal
{
    private bool _isComplete;
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            Console.WriteLine($"Sorry! You have lost {Points} points.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{Name}|{Description}|{Points}|{_isComplete}";
    }

}