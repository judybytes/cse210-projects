using System;

namespace MindfulnessProgram
{
    public class Menu
    {
        public void Display()
        {
            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Gratefulness Activity");
                Console.WriteLine("5. Quit");

                string choice = Console.ReadLine();
                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectingActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        activity = new GratefulnessActivity();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please select again.");
                        continue;
                }

                activity.Run();
            }
        }
    }
}
