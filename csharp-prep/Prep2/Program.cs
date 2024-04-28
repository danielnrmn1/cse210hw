using System;

Console.WriteLine("What grade percentage did you receive in your class? (Please enter a whole number value)");
string userGrade = Console.ReadLine();
int percent = int.Parse(userGrade);

if (percent >= 90)
{
    Console.WriteLine("You got an A!");
}
else if (percent >= 80 && percent < 90)
{
    Console.WriteLine("You got a B!");
}
else if (percent >= 70 && percent < 80)
{
    Console.WriteLine("You got a C!");
}
else if (percent >= 60 && percent < 70)
{
    Console.WriteLine("You got a D!");
}
else if (percent >= 0 && percent < 60)
{
    Console.WriteLine("You got a F!");
}
