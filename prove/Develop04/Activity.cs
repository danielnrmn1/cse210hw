public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description, int duration)
    {
        this.name = name;
        this.description = description;
        this.duration = duration;
    }

    public virtual void Run()
    {
        DisplayStartingMessage();
        Pause(3);

        for (int i = 0; i < duration; i++)
        {
            PerformActivityStep();
        }

        DisplayEndingMessage();
        Pause(3);
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"--- {name} ---");
        Console.WriteLine(description);
        Console.WriteLine("Please enter in your desired duration of the activity in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    protected abstract void PerformActivityStep();

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Congrats! You have completed the activity!");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine($"Duration: {duration} seconds");
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
        Console.WriteLine();
    }
}