using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        int convertedGrade = int.Parse(userGrade);
        string letter;
        int lastDigit = convertedGrade % 10;
        string gradeSign = "";

        if (convertedGrade >= 90)
        {
            letter = "A";
        }
        else if (convertedGrade >= 80)
        {
            letter = "B";
        }
        else if (convertedGrade >= 70)
        {
            letter = "C";
        }
        else if (convertedGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (convertedGrade >= 70)
        {
            Console.WriteLine("COngratulations, You pass");
        }
        else
        {
            Console.WriteLine("Sorry you fail, you'll do better next time");
        }

        if (lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigit < 3)
        {
            gradeSign = "-";
        }
        else 
        {
            gradeSign = "";
        }
        
        if (convertedGrade > 93)
        {
            gradeSign = "";
        }
        if (letter == "F")
        {
            gradeSign = "";
        }
        Console.WriteLine($"Your grade is {letter}{gradeSign}");
    }
}