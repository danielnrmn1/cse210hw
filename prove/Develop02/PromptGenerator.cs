using System;

public class PromptGenerator
{
    private static List<string> prompts = new List<string>()
    {
        "What was your favorite memory from today?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What were you most proud of today?",
        "What goals do you have for tomorrow?"

    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randomPrompt = prompts[index];
        return randomPrompt;
    }
}