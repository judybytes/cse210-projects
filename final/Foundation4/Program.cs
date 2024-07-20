using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create activities
        var running = new Running(new DateTime(2024, 7, 1), 30, 3.0);
        var cycling = new Cycling(new DateTime(2024, 7, 2), 45, 15.0);
        var swimming = new Swimming(new DateTime(2024, 7, 3), 60, 20);

        // Store activities in a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display activity summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
