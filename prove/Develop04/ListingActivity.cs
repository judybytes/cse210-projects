using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowCountDown(5);

            List<string> items = new List<string>();
            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.Write("Enter item: ");
                items.Add(Console.ReadLine());
                elapsed += 5;
            }

            Console.WriteLine($"You listed {items.Count} items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            DisplayEndingMessage();
        }
    }
}
