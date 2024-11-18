using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    //Creating 3 constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int Top, int Bottom)
    {
        _top = Top;
        _bottom = Bottom;
    }

    //Creating getters and setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int Top)
    {
        _top = Top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int Bottom)
    {
        _bottom = Bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double) _top/_bottom;
    }
}