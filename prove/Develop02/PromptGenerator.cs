using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "If my day were a movie, what would the title be?",
        "What was a positive surprise today?",
        "What does success look like to me?",
        "What progress did I make on my goals today?",
        "What did I learn today",
        
    };
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        return _prompts[randomGenerator.Next(_prompts.Count)];
    }
}