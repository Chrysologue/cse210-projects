using System;
using System.Globalization;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int Duration
    {
        get {return _duration;}
        set {_duration = value;}
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine($"\nThis activity will help you {_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(_duration/4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(_duration/4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(_duration/4);
    }
    public void ShowSpinner(int seconds)
    {
        List<String> spinners = new List<string>{"\\", "|", "/", "-" };
        int x = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(spinners[x]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            x++;
            if (x >= spinners.Count)
            {
                x = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int x = seconds; x > 0; x--)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}