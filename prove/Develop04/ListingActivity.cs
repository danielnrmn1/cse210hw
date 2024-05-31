public class ListeningActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity(string name, string description) : base(name, description, 0)
    {
    }

    protected override void PerformActivityStep()
    {
        Console.WriteLine(GetRandomPrompt());
        Pause(3);
        Console.WriteLine("Think about the prompt and start listing items: ");
        Console.ReadLine();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}