using System;

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Denver", "CO", "USA");

        // Create events
        Lecture lecture = new Lecture("Tech Conference", "A conference on the latest in technology.", new DateTime(2024, 8, 10), new TimeSpan(9, 0, 0), address1, "Jane Doe", 100);
        Reception reception = new Reception("Wedding Reception", "Reception for John and Jane's wedding.", new DateTime(2024, 9, 20), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun summer picnic in the park.", new DateTime(2024, 7, 25), new TimeSpan(12, 0, 0), address3, "Sunny with a chance of clouds");

        // Store events in a list
        var events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event information
        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}
