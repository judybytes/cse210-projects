using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class GratefulnessActivity : Activity
    {
        public GratefulnessActivity() : base("Gratefulness", "This activity will help you reflect on things you are grateful for in your life.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            List<string> gratefulList = new List<string>();

            Console.WriteLine("Think about things you are grateful for. You can list as many as you want.");
            ShowCountDown(5);

            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.Write("Enter something you are grateful for: ");
                gratefulList.Add(Console.ReadLine());
                elapsed += 5;
            }

            Console.WriteLine("Here's what you are grateful for:");
            foreach (var item in gratefulList)
            {
                Console.WriteLine(item);
            }

            DisplayEndingMessage();
        }
    }
}
