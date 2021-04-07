using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var delivery = new HomeDelivery("Jack", "11 - 15");
            var products = new ProductCollection<Product>[2];
            products[0] = new ProductCollection<Product>(2, new Milk());
            products[1] = new ProductCollection<Product>(1, new Sausage());
            var order = new Order<HomeDelivery>(delivery, 2, "Different goods", products);
            order.DisplayOrder();

            Console.ReadKey();
        }
    }
}
