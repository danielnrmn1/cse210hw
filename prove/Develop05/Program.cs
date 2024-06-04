using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        SaveGoals goalManager = new SaveGoals();
        int points = 0;
        int goalNumber;

        while (true)
        {
            Console.WriteLine($"You have {points} points!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Simple Goal");
            Console.WriteLine("2. Create New Eternal Goal");
            Console.WriteLine("3. Create New Checklist Goal");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Record Event");
            Console.WriteLine("8. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewSimpleGoal(goalManager);
                    break;

                case "2":
                    CreateNewEternalGoal(goalManager);
                    break;

                case "3":
                    CreateNewChecklistGoal(goalManager);
                    break;

                case "4":
                    goalManager.ListGoals();
                    break;

                case "5":
                    Console.WriteLine("Enter the name of the file you would like to save to:");
                    string fileName = Console.ReadLine();
                    goalManager.SaveToFile(fileName);
                    Console.WriteLine("Goals saved to file.");
                    break;

                case "6":
                    Console.WriteLine("Enter the name of the file you would like to load goals from:");
                    fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        goalManager.LoadFromFile(fileName);
                        Console.WriteLine("Goals loaded from file.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;

                case "7":
                    Console.WriteLine("Enter the goal number you want to record an event for:");
                    goalNumber = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(goalNumber, ref points);
                    break;

                case "8":
                    Console.WriteLine("Thank you for using Online Goals! Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter just the number of the option you would like to select");
                    break;
            }
        }
    }

    private static void CreateNewSimpleGoal(SaveGoals goalManager)
    {
        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new SimpleGoal(name, description, points);
        goalManager.AddGoal(goal);

        Console.WriteLine("Simple goal created successfully.");
    }

    private static void CreateNewEternalGoal(SaveGoals goalManager)
    {
        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new EternalGoal(name, description, points);
        goalManager.AddGoal(goal);

        Console.WriteLine("Eternal goal created successfully.");
    }

    private static void CreateNewChecklistGoal(SaveGoals goalManager)
    {
        Console.WriteLine("Enter the goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the goal points:");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the checklist amount:");
        int checklistAmount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bonus amount:");
        int bonusAmount = int.Parse(Console.ReadLine());

        Goal goal = new ChecklistGoal(name, description, points, checklistAmount, bonusAmount);
        goalManager.AddGoal(goal);

        Console.WriteLine("Checklist goal created successfully.");
    }
}