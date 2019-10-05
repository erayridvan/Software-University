using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .OrderBy(x => x)
                 .ToArray();

            Console.WriteLine(string.Join(", ",arr));

        }
    }
}
