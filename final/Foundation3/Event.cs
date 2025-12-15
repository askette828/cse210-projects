using System;

namespace EventPlanning
{
    public abstract class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private TimeSpan _time;
        private Address _address;

        protected Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            _title = title;
            _description = description;
            _date = date.Date;
            _time = time;
            _address = address;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value.Date;
        }

        public TimeSpan Time
        {
            get => _time;
            set => _time = value;
        }

        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        // Standard details: title, description, date, time, address
        public virtual string GetStandardDetails()
        {
            return
                $"Title: {Title}\n" +
                $"Description: {Description}\n" +
                $"Date: {Date:MMMM d, yyyy}\n" +
                $"Time: {Time:hh\\:mm}\n" +
                $"Address:\n{Address}";
        }

        // Full details: base + type-specific info — derived classes override or extend
        public abstract string GetFullDetails();

        // Short description: type, title, date
        public abstract string GetShortDescription();

        // Helper: format date nicely for short description
        protected string DateShort() => Date.ToString("MMMM d, yyyy");
    }
}
