using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        // Prompt the user for a series of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average of the numbers
        double average = (double)sum / numbers.Count;

        // Find the maximum number in the list
        int maxNumber = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        // Output the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Stretch Challenge: Find the smallest positive number
        int minPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers found.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }

        // Stretch Challenge: Sort and display the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

