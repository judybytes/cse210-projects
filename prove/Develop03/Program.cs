using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Example scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
}
