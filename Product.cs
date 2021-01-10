using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class Product : IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Energy { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Product product = obj as Product;
            if (product != null)
                return this.ID.CompareTo(product.ID);
            else
                throw new ArgumentException("Object is not a Product");
        }

        public override string ToString()
        {
            return $"Name: {Name} (Energy: {Energy})";
        }
    }
}
