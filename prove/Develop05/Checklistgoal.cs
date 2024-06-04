using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    public int ChecklistAmount { get; }
    public int BonusAmount { get; }
    private int completedCount;

    public ChecklistGoal(string name, string description, int points, int checklistAmount, int bonusAmount)
        : base(name, description, points)
    {
        ChecklistAmount = checklistAmount;
        BonusAmount = bonusAmount;
        completedCount = 0;
    }

    public override void RecordEvent(ref int points)
    {
        points += Points;
        completedCount++;

        Console.WriteLine($"Event recorded successfully. You gained {Points} points. You have completed {completedCount} out of {ChecklistAmount}.");

        if (completedCount == ChecklistAmount)
        {
            points += BonusAmount;
            Console.WriteLine($"Congratulations! You completed the checklist goal and gained a bonus of {BonusAmount} points. You have {points} points now.");
        }
    }
}