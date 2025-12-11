using System;
using System.Collections.Generic;
using System.Text;

namespace MindfulnessApp
{
    class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private Queue<string> _promptQueue;

        public ListingActivity() : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _promptQueue = new Queue<string>(_prompts.OrderBy(x => _rng.Next()));
        }

        private string GetNextPrompt()
        {
            if (_promptQueue.Count == 0) _promptQueue = new Queue<string>(_prompts.OrderBy(x => _rng.Next()));
            return _promptQueue.Dequeue();
        }

        public override void Run()
        {
            Start();

            string prompt = GetNextPrompt();
            Console.WriteLine(prompt);
            Console.WriteLine("You will have a few seconds to think and then start listing items. Press Enter after each item.\n");
            Console.Write("Starting in: ");
            ShowCountdown(5);

            DateTime end = DateTime.Now.AddSeconds(DurationSeconds);
            List<string> items = new List<string>();

            Console.WriteLine("Start listing now (press Enter after each item):\n");

            StringBuilder current = new StringBuilder();
            while (DateTime.Now < end)
            {
                while (Console.KeyAvailable && DateTime.Now < end)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        string entry = current.ToString().Trim();
                        if (!string.IsNullOrEmpty(entry))
                        {
                            items.Add(entry);
                            Console.WriteLine($"- {entry}");
                        }
                        current.Clear();
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (current.Length > 0)
                        {
                            current.Length -= 1;
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        current.Append(key.KeyChar);
                        Console.Write(key.KeyChar);
                    }
                }

                Thread.Sleep(100);
            }

            if (current.Length > 0)
            {
                string last = current.ToString().Trim();
                if (!string.IsNullOrEmpty(last))
                {
                    items.Add(last);
                    Console.WriteLine();
                    Console.WriteLine($"- {last}");
                }
            }

            Console.WriteLine($"\nYou listed {items.Count} item(s). Good job!");

            End();
        }
    }
}
