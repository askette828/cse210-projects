using System;

namespace ExerciseTracker
{
   
    public abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes; 
        protected Activity(DateTime date, int lengthMinutes)
        {
            _date = date.Date;
            _lengthMinutes = lengthMinutes >= 0 ? lengthMinutes : throw new ArgumentOutOfRangeException(nameof(lengthMinutes));
        }

        public DateTime Date => _date;
        public int LengthMinutes => _lengthMinutes;

       
        public abstract double GetDistanceKm();

        public virtual double GetSpeedKph()
        {
            double hours = LengthMinutes / 60.0;
            if (hours <= 0) return 0.0;
            return GetDistanceKm() / hours;
        }

        
        public virtual double GetPaceMinPerKm()
        {
            double distance = GetDistanceKm();
            if (distance <= 0) return 0.0;
            return LengthMinutes / distance;
        }

       
        public abstract string GetSummary();

        protected static string FormatDouble(double value, int decimals = 2) =>
            Math.Round(value, decimals).ToString($"F{decimals}");
    }
}
