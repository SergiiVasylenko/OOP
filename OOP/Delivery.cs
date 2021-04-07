using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Delivery
    {
        public string Address;

        public virtual void SendMessageToCustomer()
        {
            Console.WriteLine("Hi, your order was delivered to our store.");
        }
    }
}
