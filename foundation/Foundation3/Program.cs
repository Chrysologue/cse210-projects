using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 12), 30, 3.5),
            new Cycling(new DateTime(2024, 11, 20), 45, 5.8),
            new Swimming(new DateTime(2024, 11, 22), 20, 5)
        };
        Console.WriteLine();
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}