using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateforNames
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ")
                .Where(x=>x.Length<=n)
                .ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }   
        }
    }
}
