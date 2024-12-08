using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Activity Log Tracking
        // Tracks the number of times each activity is performed during the session and displays a summary at the end..
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflecting Activity", 0 },
            { "Listing Activity", 0 },
        };

        string[] choices =
        {
            "Start breathing activity",
            "Start reflecting activity",
            "Start listing activity",
            "Quit"
        };

        int choice = 0;
        BreathingActivity activity = new BreathingActivity("Breathing activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ListingActivity activity3 = new ListingActivity(new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        }, "Listing activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ReflectingActivity activity2 = new ReflectingActivity("Reflecting activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        while (choice != 4)
        {
            Console.WriteLine("Menu options");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {choices[i]}");
            }

            Console.Write("Select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                activity.Run();
                activityLog["Breathing Activity"]++;
            }
            else if (choice == 2)
            {
                activity2.Run();
                activityLog["Reflecting Activity"]++;
            }
            else if (choice == 3)
            {
                activity3.Run();
                activityLog["Listing Activity"]++;
            }
        }

        // Display summary
        Console.WriteLine("Summary of activities performed:");
        foreach (var log in activityLog)
        {
            Console.WriteLine($"{log.Key}: {log.Value} times");
        }
    }
}
