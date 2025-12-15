using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address,
                         string rsvpEmail)
            : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        public string RsvpEmail
        {
            get => _rsvpEmail;
            set => _rsvpEmail = value;
        }

        public override string GetFullDetails()
        {
            return
                GetStandardDetails() + "\n" +
                $"Event Type: Reception\n" +
                $"RSVP Email: {RsvpEmail}";
        }

        public override string GetShortDescription()
        {
            return $"Reception: {Title} - {Date.ToString("MMMM d, yyyy")}";
        }
    }
}
