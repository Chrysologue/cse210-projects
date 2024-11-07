using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int listLenght = numbers.Count;
        int largest = numbers[0];
        foreach (int value in numbers)
        {
            sum += value;
            if (largest < value)
            {
                largest = value;
            }
        }
        double average = (double) sum / listLenght;
        double roundedValue = Math.Round(average, 3);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {roundedValue}");
        Console.WriteLine($"The largest number is: {largest}");
        int smallestPositiveNumber = numbers.Where(x => x > 0).Min();
        Console.WriteLine($"The smallest positive number is {smallestPositiveNumber}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }
    }
}