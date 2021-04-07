using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class HomeDelivery : Delivery
    {
        string courier;
        string timeCustomerAtHome;
        public HomeDelivery(string courier, string timeCustomerAtHome)
        {
            this.courier = courier;
            this.timeCustomerAtHome = timeCustomerAtHome;
        }

        public override void SendMessageToCustomer()
        {
            base.SendMessageToCustomer();
            Console.WriteLine($"I am {courier} will be at {timeCustomerAtHome}");
        }
    }
}
