using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int minValue = numbers.Min();
            Console.WriteLine(minValue);
        }
    }
}
