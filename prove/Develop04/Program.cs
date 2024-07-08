using System;

// Description of how I exceeded the requirements:
// 1. Added an additional activity called "Gratefulness Activity" that helps users reflect on things they are grateful for.
// 2. Included comments explaining each class and method.
// 3. Enhanced the animations and user prompts for a better user experience.

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Display();
        }
    }
}
