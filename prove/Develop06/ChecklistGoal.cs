using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points");
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _bonus)
            {
                Points += _bonus;
                Console.WriteLine($"You have earned a bonus! Total points now: {Points} points.");
            }
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status = (IsComplete()) ? "[X]" : "[]";
        return $"{status} {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}";

    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name}|{Description}|{Points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}