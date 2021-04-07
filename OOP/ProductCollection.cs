using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class ProductCollection<T> where T : Product
    {
        public int count;
        public T product;

        public ProductCollection(int count, T product)
        {
            this.count = count;
            this.product = product;
        }
    }
}
