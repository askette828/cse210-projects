using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace MindfulnessApp
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private int _durationSeconds;

        protected static Random _rng = new Random();

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int DurationSeconds { get { return _durationSeconds; } protected set { _durationSeconds = value; } }

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Start()
        {
            Console.Clear();
            Console.WriteLine($"--- {Name} ---\n");
            Console.WriteLine(Description + "\n");
            SetDurationFromUser();
            Console.WriteLine("Get ready...\n");
            ShowSpinner(3);
        }

        public virtual void End()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!\n");
            Console.WriteLine($"You have completed the {Name} for {DurationSeconds} seconds.");
            ShowSpinner(4);
            LogActivity();
        }

        protected void SetDurationFromUser()
        {
            while (true)
            {
                Console.Write("Enter duration in seconds (e.g. 30): ");
                string input = Console.ReadLine()?.Trim();
                if (int.TryParse(input, out int secs) && secs > 0)
                {
                    DurationSeconds = secs;
                    break;
                }
                Console.WriteLine("Please enter a valid positive integer for seconds.");
            }
        }

        protected void ShowSpinner(int seconds)
        {
            char[] spinner = new char[] { '|', '/', '-', '\\' };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0;
            while (DateTime.Now < end)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
                i++;
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void BreathingVisual(int totalMs)
        {
            int steps = 6;
            int delay = Math.Max(50, totalMs / (steps * 2));

            for (int s = 1; s <= steps; s++)
            {
                Console.Write(new string('.', s));
                Thread.Sleep(delay);
                Console.Write(new string('\b', s));
                Console.Write(new string(' ', s));
                Console.Write(new string('\b', s));
            }

            for (int s = steps; s >= 1; s--)
            {
                Console.Write(new string('.', s));
                Thread.Sleep(delay);
                Console.Write(new string('\b', s));
                Console.Write(new string(' ', s));
                Console.Write(new string('\b', s));
            }
            Console.WriteLine();
        }

        public abstract void Run();

        private void LogActivity()
        {
            try
            {
                string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{Name}\t{DurationSeconds}s";
                File.AppendAllLines("mindfulness_log.txt", new string[] { logLine });
            }
            catch
            {
                // ignore logging errors
            }
        }
    }
}
