using System;

namespace MindfulnessApp
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Run()
        {
            Start();

            DateTime end = DateTime.Now.AddSeconds(DurationSeconds);
            bool breatheIn = true;
            int inhaleSeconds = 5; // show explicit seconds for inhale
            int exhaleSeconds = 5; // show explicit seconds for exhale

            while (DateTime.Now < end)
            {
                if (breatheIn)
                {
                    Console.WriteLine($"Breathe in... ({inhaleSeconds} seconds)");
                    int remaining = (int)(end - DateTime.Now).TotalSeconds;
                    int showSec = Math.Min(inhaleSeconds, Math.Max(1, remaining));
                    BreathingVisual(showSec * 1000);
                    ShowCountdown(showSec);
                }
                else
                {
                    Console.WriteLine($"Breathe out... ({exhaleSeconds} seconds)");
                    int remaining = (int)(end - DateTime.Now).TotalSeconds;
                    int showSec = Math.Min(exhaleSeconds, Math.Max(1, remaining));
                    BreathingVisual(showSec * 1000);
                    ShowCountdown(showSec);
                }

                breatheIn = !breatheIn;
            }

            End();
        }
    }
}
