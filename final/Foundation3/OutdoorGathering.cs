using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address,
                                string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public string WeatherForecast
        {
            get => _weatherForecast;
            set => _weatherForecast = value;
        }

        public override string GetFullDetails()
        {
            return
                GetStandardDetails() + "\n" +
                $"Event Type: Outdoor Gathering\n" +
                $"Weather Forecast: {WeatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Outdoor Gathering: {Title} - {Date.ToString("MMMM d, yyyy")}";
        }
    }
}
