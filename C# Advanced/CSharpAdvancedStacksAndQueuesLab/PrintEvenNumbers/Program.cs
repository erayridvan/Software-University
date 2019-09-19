using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(nums);
            List<int> evenNumbers = new List<int>();

            int index = numbers.Count;

            for (int i = 0; i < index; i++)
            {
                int currentNumber = numbers.Peek();

                if (currentNumber%2==0)
                {
                    evenNumbers.Add(currentNumber);
                    numbers.Dequeue();
                }
                else
                {
                    numbers.Dequeue();
                }
            }

            Console.WriteLine(string.Join("," , evenNumbers));
        }
    }
}
