using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    protected override void PerformActivityStep()
    {
        Console.WriteLine("Breathe in...");
        Pause(3);

        int counter = 0;
        int breatheOutDuration = 3;

        while (counter < duration)
        {
            if (counter + (breatheOutDuration + 3) > duration)
            {
                breatheOutDuration = duration - counter - 3;
                if (breatheOutDuration <= 0)
                    break;
            }

            Console.WriteLine("Breathe out...");
            Pause(breatheOutDuration);
            Console.WriteLine("Breathe in...");
            Pause(3);
            counter += (breatheOutDuration + 3);
            breatheOutDuration += 2; // Increase the breathe out duration by 2 seconds
        }
    }

    public override void Run()
    {
        DisplayStartingMessage();
        base.Run();
    }
}