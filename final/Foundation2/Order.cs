using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        public Customer Customer
        {
            get => _customer;
            set => _customer = value ?? throw new ArgumentNullException(nameof(value));
        }

       
        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            _products.Add(product);
        }

       
        public decimal GetTotalPrice()
        {
            decimal subtotal = 0m;
            foreach (var p in _products)
            {
                subtotal += p.GetTotalCost();
            }

            subtotal += GetShippingCost(); // one-time shipping fee
            return subtotal;
        }

        public decimal GetShippingCost()
        {
            return Customer != null && Customer.LivesInUSA() ? 5m : 35m;
        }

        
        public string GetPackingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (var p in _products)
            {
                sb.AppendLine($"- {p.Name} (Product ID: {p.ProductId})");
            }
            return sb.ToString().TrimEnd();
        }

        
        public string GetShippingLabel()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Shipping Label:");
            sb.AppendLine(Customer.Name);
            sb.AppendLine(Customer.Address.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
