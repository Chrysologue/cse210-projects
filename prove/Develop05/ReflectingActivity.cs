using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    Random rand = new Random();
    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }
    public string GetRandomPrompt()
    {
        string randomPrompt = _prompts[rand.Next(_prompts.Count)];
        return randomPrompt;

    }
    public string GetRandomQuestion()
    {
        string randomQuestion = _questions[rand.Next(_questions.Count)];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestions(DateTime endTime)
{
    while (DateTime.Now < endTime)
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(Duration/2);
        Console.WriteLine();
    }
}
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
    
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        DisplayQuestions(endTime);

        DisplayEndingMessage();
        Console.Clear();
    }
}