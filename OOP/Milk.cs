using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Milk : Product
    {
        public override string Name { get => "Milk"; }
        public override void Description()
        {
            Console.WriteLine($"{Name} is healthy food!");
        }
    }
}
