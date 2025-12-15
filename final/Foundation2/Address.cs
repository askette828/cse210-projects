using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street ?? throw new ArgumentNullException(nameof(street));
            _city = city ?? throw new ArgumentNullException(nameof(city));
            _stateOrProvince = stateOrProvince ?? throw new ArgumentNullException(nameof(stateOrProvince));
            _country = country ?? throw new ArgumentNullException(nameof(country));
        }

        public string Street
        {
            get => _street;
            set => _street = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string City
        {
            get => _city;
            set => _city = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string StateOrProvince
        {
            get => _stateOrProvince;
            set => _stateOrProvince = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Country
        {
            get => _country;
            set => _country = value ?? throw new ArgumentNullException(nameof(value));
        }

        
        public bool IsInUSA()
        {
            // Compare case-insensitively and trim whitespace
            return string.Equals(_country?.Trim(), "USA", StringComparison.OrdinalIgnoreCase)
                || string.Equals(_country?.Trim(), "United States", StringComparison.OrdinalIgnoreCase)
                || string.Equals(_country?.Trim(), "United States of America", StringComparison.OrdinalIgnoreCase)
                || string.Equals(_country?.Trim(), "US", StringComparison.OrdinalIgnoreCase);
        }

       
        public override string ToString()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }
}
