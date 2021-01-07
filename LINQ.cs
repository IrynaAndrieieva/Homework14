using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class LINQ
    {
        Random rnd = new Random();

        public void MetodLinq()
        {            
            var collection = new List<Product>();

            for (var i = 0; i < 100; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(0, 500)
                };

                collection.Add(product);
            }

            var result = from item in collection
                         where item.Energy < 200
                         select item;

            var result2 = collection.Where(item => item.Energy < 200)
                                    .OrderBy(item => item.Energy);

            foreach (var item in result)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("__________");

            foreach (var item in result2)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}