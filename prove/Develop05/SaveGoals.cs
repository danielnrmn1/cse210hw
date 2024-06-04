using System;
using System.Collections.Generic;
using System.IO;

public class SaveGoals
{
    private List<Goal> goals;

    public SaveGoals()
    {
        goals = new List<Goal>();
    }
 
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return goals;
    }

    public void ClearGoals()
    {
        goals.Clear();
    }


    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Description);
                writer.WriteLine(goal.Points);

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.ChecklistAmount);
                    writer.WriteLine(checklistGoal.BonusAmount);
                }
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());

                if (goalType == nameof(SimpleGoal))
                {
                    Goal goal = new SimpleGoal(name, description, points);
                    AddGoal(goal);
                }
                else if (goalType == nameof(EternalGoal))
                {
                    Goal goal = new EternalGoal(name, description, points);
                    AddGoal(goal);
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    int checklistAmount = int.Parse(reader.ReadLine());
                    int bonusAmount = int.Parse(reader.ReadLine());
                    Goal goal = new ChecklistGoal(name, description, points, checklistAmount, bonusAmount);
                    AddGoal(goal);
                }
            }
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("List of Goals:");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            for (int i = 0; i < goals.Count; i++)
            {
                Goal goal = goals[i];
                Console.WriteLine($"{goal.Name}");
                Console.WriteLine($"Description: {goal.Description}");
                Console.WriteLine($"Points: {goal.Points}");
                Console.WriteLine();
            }
        }
    }
    public void RecordEvent(int goalNumber, ref int points)
    {
        if (goalNumber > 0 && goalNumber <= goals.Count)
        {
            Goal goal = goals[goalNumber - 1];
            goal.RecordEvent(ref points);
            Console.WriteLine($"Event recorded successfully for Goal {goalNumber}. You gained {goal.Points} points. You have {points} points now.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}