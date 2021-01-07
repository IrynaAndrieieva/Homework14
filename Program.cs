using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLargesWhisLinq(@"D:\Программы");
            Console.ReadKey();
        }

        private static void DisplayLargesWhisLinq(string pathToDir)
        {
            IReadOnlyList<FileInfo> orderedFiles = new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderBy(file => file.Length)
                .Take(5)
                .ToList();

            foreach (var file in orderedFiles)
            {
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }
    }
}
