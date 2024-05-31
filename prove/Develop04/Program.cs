using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listening Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select an Activity: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    break;
                case 2:
                    activity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;
                case 3:
                    activity = new ListeningActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (activity != null)
            {
                activity.Run();
                Console.WriteLine();
            }
        }
    }
}