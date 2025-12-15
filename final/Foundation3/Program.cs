using System;
using EventPlanning;

namespace EventPlanningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture
            Address lectureAddress = new Address("12 University Ave", "Boston", "MA", "USA");
            Lecture lecture = new Lecture(
                title: "The Future of AI",
                description: "A deep dive into the next decade of AI research and applications.",
                date: new DateTime(2026, 3, 15),
                time: new TimeSpan(18, 30, 0),
                address: lectureAddress,
                speaker: "Dr. Mira Patel",
                capacity: 150
            );

            // Reception
            Address receptionAddress = new Address("500 Market St", "San Francisco", "CA", "USA");
            Reception reception = new Reception(
                title: "Startup Mixer 2026",
                description: "Network with founders, investors, and engineers in the Bay Area.",
                date: new DateTime(2026, 4, 2),
                time: new TimeSpan(19, 0, 0),
                address: receptionAddress,
                rsvpEmail: "rsvp@startupmixer.com"
            );

            // Outdoor Gathering
            Address outdoorAddress = new Address("Greenfield Park", "Vancouver", "BC", "Canada");
            OutdoorGathering outdoor = new OutdoorGathering(
                title: "Community Yoga in the Park",
                description: "Free morning yoga for all levels—bring a mat and water.",
                date: new DateTime(2026, 5, 10),
                time: new TimeSpan(9, 0, 0),
                address: outdoorAddress,
                weatherForecast: "Sunny with light breeze, high 22°C"
            );

            // Display messages for each event
            PrintEventMessages(lecture);
            PrintEventMessages(reception);
            PrintEventMessages(outdoor);
        }

        static void PrintEventMessages(Event ev)
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
        }
    }
}
