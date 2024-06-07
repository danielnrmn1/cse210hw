using System;

public class Program
{
    public static void Main()
    {
        // Create event objects
        Address lectureAddress = new Address("123 Main St", "Cityville", "Stateville", "Countryland");
        Event lectureEvent = new Lecture("Introduction to Programming", "Learn the basics of programming", DateTime.Now, "10:00 AM", lectureAddress, "John Smith", 50);

        Address receptionAddress = new Address("456 Park Ave", "Townsville", "Stateville", "Countryland");
        Event receptionEvent = new Reception("Company Reception", "Celebrate our achievements", DateTime.Now, "7:00 PM", receptionAddress, "rsvp@example.com");

        Address outdoorGatheringAddress = new Address("789 Beach Rd", "Seaside", "Stateville", "Countryland");
        Event outdoorGatheringEvent = new OutdoorGathering("Summer Picnic", "Enjoy fun activities and food", DateTime.Now, "12:00 PM", outdoorGatheringAddress, "Sunny weather expected");

        // Generate marketing messages
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
}