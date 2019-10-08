using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> myCustomComparator = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }

                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;
                }

                if (a % 2 != 0 && b % 2 != 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }

                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;
                }

                if (a % 2 == 0)
                {
                    return -1;
                }

                if (a % 2 != 0)
                {
                    return 1;
                }
                return 0;
            };

            Array.Sort(input, new Comparison<int>(myCustomComparator));

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
