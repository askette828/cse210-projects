using System;
using System.Collections.Generic;
using System.Linq;

namespace MindfulnessApp
{
    class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private Queue<string> _promptQueue;
        private Queue<string> _questionQueue;

        public ReflectionActivity() : base("Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            ShuffleQueues();
        }

        private void ShuffleQueues()
        {
            _promptQueue = new Queue<string>(_prompts.OrderBy(x => _rng.Next()));
            _questionQueue = new Queue<string>(_questions.OrderBy(x => _rng.Next()));
        }

        private string GetNextPrompt()
        {
            if (_promptQueue.Count == 0) ShuffleQueues();
            return _promptQueue.Dequeue();
        }

        private string GetNextQuestion()
        {
            if (_questionQueue.Count == 0) ShuffleQueues();
            return _questionQueue.Dequeue();
        }

        public override void Run()
        {
            Start();

            Console.WriteLine(GetNextPrompt());
            Console.WriteLine("Take a moment to think about that...\n");
            ShowSpinner(4);

            DateTime end = DateTime.Now.AddSeconds(DurationSeconds);

            while (DateTime.Now < end)
            {
                string q = GetNextQuestion();
                Console.WriteLine(q);
                int maxPause = 6;
                int remaining = (int)(end - DateTime.Now).TotalSeconds;
                int show = Math.Min(maxPause, Math.Max(1, remaining));
                ShowSpinner(show);
            }

            End();
        }
    }
}
