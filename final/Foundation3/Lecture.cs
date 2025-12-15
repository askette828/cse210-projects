using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address,
                       string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public string Speaker
        {
            get => _speaker;
            set => _speaker = value;
        }

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public override string GetFullDetails()
        {
            return
                GetStandardDetails() + "\n" +
                $"Event Type: Lecture\n" +
                $"Speaker: {Speaker}\n" +
                $"Capacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Lecture: {Title} - {Date.ToString("MMMM d, yyyy")}";
        }
    }
}
