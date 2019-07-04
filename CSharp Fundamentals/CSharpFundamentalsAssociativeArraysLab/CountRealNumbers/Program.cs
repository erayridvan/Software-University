using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!(numbersCount.ContainsKey(numbers[i])))
                {
                    numbersCount[numbers[i]] = 0;
                }
                numbersCount[numbers[i]]++;
            }

            foreach (var number in numbersCount)
            {
                var keyNumber = number.Key;
                var value = number.Value;

                Console.WriteLine($"{keyNumber} -> {value}");
            }
        }
    }
}
