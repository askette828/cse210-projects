using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class VisualizationActivity : Activity
    {
        private List<string> _scenes = new List<string>
        {
            "A calm beach at sunrise: feel the warm sand and hear gentle waves.",
            "A quiet forest: tall trees, birds chirping, and a soft breeze.",
            "A peaceful mountain top: cool air, wide view, and sunlight on your face.",
            "A cozy room with a warm drink and a soft chair, feeling safe and comfortable."
        };

        public VisualizationActivity() : base("Visualization Activity",
            "This activity will guide you to imagine a peaceful scene to relax your mind and body.")
        {
        }

        public override void Run()
        {
            Start();

            string scene = _scenes[_rng.Next(_scenes.Count)];
            Console.WriteLine(scene + "\n");
            Console.WriteLine("Close your eyes (if comfortable) and imagine the details.");
            Console.WriteLine("You'll be guided through senses: sight, sound, smell, touch, and feeling.\n");

            DateTime end = DateTime.Now.AddSeconds(DurationSeconds);

            string[] guides = new string[]
            {
                "Notice what you can see in this scene.",
                "Notice what you can hear.",
                "Notice any smells or sensations.",
                "Notice what you can touch or feel physically.",
                "Notice how this place makes you feel emotionally."
            };

            int idx = 0;
            while (DateTime.Now < end)
            {
                Console.WriteLine(guides[idx % guides.Length]);
                int remaining = (int)(end - DateTime.Now).TotalSeconds;
                int pause = Math.Min(6, Math.Max(2, remaining));
                ShowSpinner(pause);
                idx++;
            }

            End();
        }
    }
}
