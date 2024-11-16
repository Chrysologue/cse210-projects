using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        string[] options = {"Write", "Display", "Load", "Save", "Quit", "Set reminder"};
        Console.WriteLine("Welcome to the journal program");
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            for (int x = 0; x < 6; x++)
            {
                Console.WriteLine($"{x + 1}. {options[x]}");
            }
            Console.Write("What would you like to do: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                //instantiating of PromptGenerator class
                PromptGenerator prompt = new PromptGenerator();
                string chosenPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(chosenPrompt);
                string userEntry = Console.ReadLine();

                //Instantiating Entry class
                Entry entry = new Entry(chosenPrompt, userEntry);
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 3)
            {
                string filename;
                Console.WriteLine("What is the name of the file?");
                filename = Console.ReadLine();
                journal.LoadFromFIle(filename);
            }
            
            //sixth option added to set reminder to remind people to write in their journal.
            else if (choice == 6)
            {
                Console.WriteLine("Set reminder time of format (HH:MM)");
                string[] timeParts = Console.ReadLine().Split(":");
                TimeSpan reminderTime = new TimeSpan(int.Parse(timeParts[0]), int.Parse(timeParts[1]), 0);
                Reminder reminder = new Reminder();
                reminder.SetReminder(reminderTime);
            }
        }
    }
}