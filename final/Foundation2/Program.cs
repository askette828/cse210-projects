using System;
using System.Collections.Generic;
using OnlineOrdering;

namespace OnlineOrderingApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Customer customer1 = new Customer("Alice Johnson", addr1);

            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Wireless Mouse", "WM-100", 25.99m, 2));
            order1.AddProduct(new Product("USB-C Cable", "USBC-10", 8.50m, 3));

          
            Address addr2 = new Address("99 Queen St", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Bruno Santos", addr2);

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("External HDD 1TB", "HDD-1TB", 79.99m, 1));
            order2.AddProduct(new Product("Laptop Sleeve", "LS-15", 19.99m, 1));
            order2.AddProduct(new Product("Bluetooth Adapter", "BT-ADP", 12.49m, 2));

 
            var orders = new List<Order> { order1, order2 };

            int idx = 1;
            foreach (var order in orders)
            {
                Console.WriteLine($"=== Order #{idx} ===");
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine();
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine();
                Console.WriteLine($"Shipping Cost: {order.GetShippingCost():C}");
                Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
                Console.WriteLine(new string('-', 40));
                idx++;
            }
        }
    }
}
