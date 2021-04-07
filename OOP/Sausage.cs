using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Sausage : Product
    {
        public override string Name => "Sausage";

        public override void Description()
        {
            Console.WriteLine($"{Name} is thrash food!");
        }
    }
}
