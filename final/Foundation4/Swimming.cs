using System;

namespace ExerciseTracker
{
   
    public class Swimming : Activity
    {
        private int _laps;
        private const double MetersPerLap = 50.0;
        private const double KmPerLap = MetersPerLap / 1000.0; // 0.05 km

        public Swimming(DateTime date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            if (laps < 0) throw new ArgumentOutOfRangeException(nameof(laps));
            _laps = laps;
        }

        public int Laps
        {
            get => _laps;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                _laps = value;
            }
        }

        public override double GetDistanceKm()
        {
            return Laps * KmPerLap;
        }

        public override string GetSummary()
        {
            string date = Date.ToString("dd MMM yyyy");
            return $"{date} Swimming ({LengthMinutes} min): Distance {FormatDouble(GetDistanceKm(), 2)} km, " +
                   $"Speed {FormatDouble(GetSpeedKph(), 2)} kph, Pace: {FormatDouble(GetPaceMinPerKm(), 2)} min per km " +
                   $"(Laps: {Laps})";
        }
    }
}
