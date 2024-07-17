using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.AddGoal();
                    break;
                case "2":
                    Console.Write("Enter the goal index to record an event: ");
                    int goalIndex;
                    if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex >= 0 && goalIndex < goalManager.CountGoals())
                    {
                        goalManager.RecordEvent(goalIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal index.");
                    }
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    Console.Write("Enter the filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;
                case "6":
                    Console.Write("Enter the filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}

