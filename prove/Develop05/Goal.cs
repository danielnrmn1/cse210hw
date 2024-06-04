using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent(ref int points);
}