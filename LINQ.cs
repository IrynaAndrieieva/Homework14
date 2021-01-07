using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class LINQ
    {
        
        public void MetodLinq()
        {
            var collection = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                collection.Add(1);
            }

            var result = from item in collection
                         where item < 5
                         select item;
        }
    }
}