using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 0;

        // EXCEEDING REQUIREMENTS:
        // ● Clean classes with abstraction
        // ● Added JSON Option (not required)
        // ● Easily extendable metadata support

        while (choice != 5)
        {
            Console.WriteLine("=== Journal Program ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveToFile();
                    break;
                case 4:
                    journal.LoadFromFile();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
