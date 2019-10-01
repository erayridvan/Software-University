using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersTimes = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersTimes.ContainsKey(number))
                {
                    numbersTimes[number] = 1;
                }
                else
                {
                    numbersTimes[number]++;
                }
            }

            foreach (var number in numbersTimes)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                    break;
                }
            }
        }
    }
}
