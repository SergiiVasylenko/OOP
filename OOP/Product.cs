using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public virtual void Description()
        {
            Console.WriteLine("None.");
        }
    }
}
