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
            var products = new List<Product>();

            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(0, 500)
                };

                products.Add(product);
            }

            Console.WriteLine("Test1");

            var whereAndOrder = products.Where(item => item.Energy < 200)
                                    .OrderBy(item => item.Energy)
                                    .ThenBy(product => product.Name);

            foreach (var item in whereAndOrder)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test2");

            var selectCollection = products.Select(product => product.Energy)
                                           .OrderByDescending(product => product);
                                           
            foreach (var item in selectCollection)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test3");

            var groupByCollection = products.GroupBy(product => product.Energy);

            foreach (var group in groupByCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach(var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }
        }
    }
}