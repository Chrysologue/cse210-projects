using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr = new Fraction();
        Console.WriteLine(fr.GetFractionString());
        Console.WriteLine(fr.GetDecimalValue());

        Fraction fr1 = new Fraction(5);
        Console.WriteLine(fr1.GetFractionString());
        Console.WriteLine(fr1.GetDecimalValue());

        Fraction fr2 = new Fraction(3, 4);
        Console.WriteLine(fr2.GetFractionString());
        Console.WriteLine(fr2.GetDecimalValue());

        Fraction fr3 = new Fraction(1, 3);
        Console.WriteLine(fr3.GetFractionString());
        Console.WriteLine(fr3.GetDecimalValue());
    }
}