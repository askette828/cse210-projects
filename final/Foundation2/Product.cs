using System;

namespace OnlineOrdering
{
    public class Product
    {
        private string _name;
        private string _productId;
        private decimal _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, decimal pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string ProductId
        {
            get => _productId;
            set => _productId = value ?? throw new ArgumentNullException(nameof(value));
        }

        public decimal PricePerUnit
        {
            get => _pricePerUnit;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Price must be >= 0");
                _pricePerUnit = value;
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Quantity must be >= 0");
                _quantity = value;
            }
        }

        
        public decimal GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }
    }
}
