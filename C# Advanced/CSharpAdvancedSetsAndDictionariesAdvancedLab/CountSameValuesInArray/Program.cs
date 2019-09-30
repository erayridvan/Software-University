using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main()
        {
            double[] values = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            var counts = new Dictionary<double, int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (!counts.ContainsKey(values[i]))
                {
                    counts[values[i]]=1;
                }
                else
                {
                    counts[values[i]] += 1;
                }
            }

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}
