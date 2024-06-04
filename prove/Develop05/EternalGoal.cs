using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent(ref int points)
    {
        points += Points;
        Console.WriteLine($"Event recorded successfully. You gained {Points} points. You have {points} points now.");
    }
}