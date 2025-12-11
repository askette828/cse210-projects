using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mindfulness Console App";
            var activities = new Dictionary<int, Activity>
            {
                { 1, new BreathingActivity() },
                { 2, new ReflectionActivity() },
                { 3, new ListingActivity() },
                { 4, new VisualizationActivity() }
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness App\n");
                Console.WriteLine("Please select an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Visualization Activity (creative extra)");
                Console.WriteLine("5. Quit\n");
                Console.Write("Enter choice (1-5): ");
                string choice = Console.ReadLine()?.Trim();
                if (choice == "5") break;

                if (int.TryParse(choice, out int c) && activities.ContainsKey(c))
                {
                    activities[c].Run();
                    Console.WriteLine("\nPress Enter to return to main menu...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Thanks for using Mindfulness App. Stay calm!\n");
        }
    }
}
