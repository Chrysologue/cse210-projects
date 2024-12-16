using System;
public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => _numberOfLaps * 50.0 / 1000 * 0.62;
    public override double GetSpeed() => (GetDistance() / Length) * 60;
    public override double GetPace() => 60 / GetSpeed();
}