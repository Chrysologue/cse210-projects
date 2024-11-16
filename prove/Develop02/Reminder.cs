using System;

// setting notification to remind people to write journal
public class Reminder
{
    public void SetReminder(TimeSpan time)
    {
        Console.WriteLine($"Your reminder is at {time.Hours:D2}:{time.Minutes:D2}");
    }
}