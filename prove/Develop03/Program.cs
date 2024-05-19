using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        Reference reference = new 
        Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life.");

        Console.Clear();
        Console.WriteLine(scripture.GetFormattedScripture());

        while (scripture.HasHiddenWords())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine(scripture.GetFormattedScripture());
        }

        Console.WriteLine("\nAll words have been hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}