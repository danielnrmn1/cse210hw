using System;

public class Program
{
    public static void Main()
    {
        
        Journal journals = new Journal();
        PromptGenerator promptGenerator1 = new PromptGenerator();

        

        while (true)
        {
            Console.WriteLine("Welcome to your digital journal!");
            Console.WriteLine("Please enter a number based on what you would like to do:");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display my past entries");
            Console.WriteLine("3. Save my new entries");
            Console.WriteLine("4. Load my saved entries");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator1.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string response = Console.ReadLine();
                    journals.AddEntry(randomPrompt, response);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    for (int i = 0; i < journals.EntryCount(); i++)
                        {
                            Console.WriteLine($"Entry {i+1}:");
                            Console.WriteLine($"Prompt: {journals.GetPrompt(i)}");
                            Console.WriteLine($"Response: {journals.GetResponse(i)}");
                            Console.WriteLine();
                        }
                    break;

                case "3":
                    Console.WriteLine("Enter the name of the file you would like to save to:");
                    string fileName = Console.ReadLine();
                    SaveEntriesToFile(journals, fileName);
                    Console.WriteLine("Entries saved to file.");
                    break;

                case "4":
                    Console.WriteLine("Enter the name of the file you would like to display:");
                    fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        LoadEntriesFromFile(journals, fileName);
                        Console.WriteLine("Entries loaded from file:");
                        for (int i = 0; i < journals.EntryCount(); i++)
                        {
                            Console.WriteLine($"Entry {i + 1}:");
                            Console.WriteLine($"Prompt: {journals.GetPrompt(i)}");
                            Console.WriteLine($"Response: {journals.GetResponse(i)}");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Thank you for using Online Journal! Goodbye!");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice. Please enter just the number of the option you would like to select");
                    break;

            }
        }
    }

    private static void SaveEntriesToFile(Journal journals, string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            for (int i = 0; i < journals.EntryCount(); i++)
            {
                sw.WriteLine(journals.GetPrompt(i));
                sw.WriteLine(journals.GetResponse(i));
            }
        }
    }

    private static void LoadEntriesFromFile(Journal journals, string fileName)
{

    using (StreamReader sr = new StreamReader(fileName))
    {
        while (!sr.EndOfStream)
        {
            string prompt = sr.ReadLine();
            string response = sr.ReadLine();
            journals.AddEntry(prompt, response);
        }
    }
}
}