using System;
using System.Collections.Generic;
using ExerciseTracker;

namespace ExerciseTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>();

            
            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));   // 3.0 km in 30 min

            activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20.0));  // avg 20 kph for 45 min

            activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 24));   // 24 laps -> 24*0.05 = 1.2 km

            activities.Add(new Running(DateTime.Today, 60, 10.0)); // 10 km in 60 min

            Console.WriteLine("Activity Summaries\n" + new string('=', 60));
            foreach (var act in activities)
            {
                Console.WriteLine(act.GetSummary());
            }

            Console.WriteLine("\nDetailed values for first activity:");
            var first = activities[0];
            Console.WriteLine($"Date: {first.Date:dd MMM yyyy}");
            Console.WriteLine($"Duration: {first.LengthMinutes} min");
            Console.WriteLine($"Distance (km): {first.GetDistanceKm():F2}");
            Console.WriteLine($"Speed (kph): {first.GetSpeedKph():F2}");
            Console.WriteLine($"Pace (min/km): {first.GetPaceMinPerKm():F2}");
        }
    }
}
