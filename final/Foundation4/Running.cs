using System;

namespace ExerciseTracker
{
    
    public class Running : Activity
    {
        private double _distanceKm; 

        public Running(DateTime date, int lengthMinutes, double distanceKm)
            : base(date, lengthMinutes)
        {
            if (distanceKm < 0) throw new ArgumentOutOfRangeException(nameof(distanceKm));
            _distanceKm = distanceKm;
        }

        public double DistanceKm
        {
            get => _distanceKm;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _distanceKm = value;
            }
        }

        public override double GetDistanceKm() => DistanceKm;

        public override string GetSummary()
        {
            string date = Date.ToString("dd MMM yyyy");
            return $"{date} Running ({LengthMinutes} min): Distance {FormatDouble(GetDistanceKm(), 2)} km, " +
                   $"Speed {FormatDouble(GetSpeedKph(), 2)} kph, Pace: {FormatDouble(GetPaceMinPerKm(), 2)} min per km";
        }
    }
}
