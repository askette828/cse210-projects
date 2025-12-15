using System;

namespace ExerciseTracker
{
   
    public class Cycling : Activity
    {
        private double _speedKph; // stored speed in km/h

        public Cycling(DateTime date, int lengthMinutes, double speedKph)
            : base(date, lengthMinutes)
        {
            if (speedKph < 0) throw new ArgumentOutOfRangeException(nameof(speedKph));
            _speedKph = speedKph;
        }

        public double SpeedKph
        {
            get => _speedKph;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _speedKph = value;
            }
        }

        public override double GetDistanceKm()
        {
            double hours = LengthMinutes / 60.0;
            return SpeedKph * hours;
        }

        public override double GetSpeedKph() => SpeedKph;

        public override string GetSummary()
        {
            string date = Date.ToString("dd MMM yyyy");
            return $"{date} Cycling ({LengthMinutes} min): Distance {FormatDouble(GetDistanceKm(), 2)} km, " +
                   $"Speed {FormatDouble(GetSpeedKph(), 2)} kph, Pace: {FormatDouble(GetPaceMinPerKm(), 2)} min per km";
        }
    }
}
