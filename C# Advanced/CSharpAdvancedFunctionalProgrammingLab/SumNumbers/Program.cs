using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            var result = arr.Sum();

            Console.WriteLine(arr.Length);
            Console.WriteLine(result);
        }
    }
}
