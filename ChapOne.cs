using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    static class ChapOne
    {
        static Random rnd = new Random();

        static public void MetodLinq()
        {
            var products = new CustomList<Product>();

            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(0, 101)
                };

                products.Add(product);
            }


            Console.WriteLine("Test1");

            IReadOnlyCollection<Product> whereAndOrder = products.Where(item => item.Energy < 200)
                                    .OrderBy(item => item.Energy)
                                    .ThenBy(product => product.Name).ToList().AsReadOnly();

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
            Console.WriteLine("Test First");

            var first = products.First();

            Console.WriteLine(first);

            Console.WriteLine("__________");
            Console.WriteLine("Test Last and LastOrDefault ");

            var last = products.Last();
            Console.WriteLine(last);

            var lastOrDef = products.LastOrDefault();
            Console.WriteLine(lastOrDef);

            Console.WriteLine("__________");
            Console.WriteLine("Test GroupBy");

            var groupByCollection = products.GroupBy(product => product.Energy);

            foreach (var group in groupByCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }


            Console.WriteLine("__________");
            Console.WriteLine("Test Reverse");

            products.Reverse();

            foreach (var item in products)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("__________");

            Console.WriteLine($"Test All: {products.All(item => item.Energy == 10)}");
            Console.WriteLine($"Test Any: {products.Any(item => item.Energy == 10)}");

            var prod = new Product();
            Console.WriteLine($"Test Contains: {products.Contains(prod)}"); //не принадлежить коллекции products

            Console.WriteLine("__________");
            Console.WriteLine("Test Union. Before union");

            var array = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 1, 2, 3, 7, 8, 9 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After union");
            var union = array.Union(array2);

            foreach (var item in union)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test Intersect");

            var intersect = array.Intersect(array2);

            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test Except");

            var except = array2.Except(array);

            foreach (var item in except)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test Skip and Take");

            var skipAndTake = array.Skip(2).Take(1);

            foreach (var item in skipAndTake)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("__________");
            Console.WriteLine("Test Single Or Default");

            var single = products.SingleOrDefault(p => p.Name == "Product9");

            Console.WriteLine(single);

            Console.WriteLine("__________");
            Console.WriteLine("Test Element At");

            var elementAt = products.ElementAt(5);

            Console.WriteLine(elementAt);
        }
     
    }
}