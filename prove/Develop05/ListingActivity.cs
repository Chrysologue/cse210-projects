using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _responses = new List<string>();

    public ListingActivity(List<string> propmts, string name, string description) : base(name, description)
    {
        _count = 5;
        _prompts = propmts;
    }
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        string randomChoice = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($"---{randomChoice}---");
        Console.Write("You may begin in: ");
        for(int x = _count; x > 0; x--)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public List<String> GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }

        }
        return _responses;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_responses.Count} items");
        DisplayEndingMessage();
        Console.Clear();
        
    }
}