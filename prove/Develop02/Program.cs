using System;

// Exceeding Requirements:
// 1. Added functionality to delete a journal entry by date.
// 2. Added functionality to search entries by keyword.
// 3. Improved the user interface with additional menu options for the new features.


public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string userChoice = "";

        while (userChoice != "6")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Delete an entry");
            Console.WriteLine("6. Search entries");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string date = DateTime.Now.ToShortDateString();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry(date, prompt, entryText);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.Write("Enter the date of the entry to delete (MM/DD/YYYY): ");
                    string deleteDate = Console.ReadLine();
                    journal.DeleteEntry(deleteDate);
                    break;
                case "6":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;
                case "7":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
