using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class PickPointDelivery : Delivery
    {
        int numberPickPoint;
        string workingTime;

        public PickPointDelivery(int numberPickPoint, string workingTime)
        {
            this.numberPickPoint = numberPickPoint;
            this.workingTime = workingTime;
        }

        public override void SendMessageToCustomer()
        {
            base.SendMessageToCustomer();
            Console.WriteLine($"You can take your order in department № {numberPickPoint} at time {workingTime}");
        }
    }
}
