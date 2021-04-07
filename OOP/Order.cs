using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        private TDelivery delivery;

        private int number;

        private string description;
        private ProductCollection<Product>[] products;

        public Order(TDelivery delivery, int number, string description, ProductCollection<Product>[] products)
        {
            this.delivery = delivery;
            this.number = number;
            this.description = description;
            this.products = products;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(delivery.Address);
        }

        public void DisplayOrder()
        {
            Console.Write("We ordered: ");
            foreach (var item in products)
            {
                Console.Write($"{item.product.Name} and count is {item.count}; ");
            }
        }
    }
}
