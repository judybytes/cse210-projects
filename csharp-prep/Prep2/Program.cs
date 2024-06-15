using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage;

        // validate input and parse it to integer
        while (!int.TryParse(input, out percentage))
        {
            Console.Write("Invalid input. Please enter a valid grade percentage: ");
            input = Console.ReadLine();
        }
        
        // initialize the letter grade variable
        string letter = "";

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check if user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }

        // Stretch challenge: Determine the sign
        string sign ="";
        if (percentage >= 60 && percentage < 90)
        {
            int lastDigit = percentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptional cases for A and F grades
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }

        // Print the final grade
        Console.WriteLine($"Your letter grade is {letter}{sign}.");
    }
}