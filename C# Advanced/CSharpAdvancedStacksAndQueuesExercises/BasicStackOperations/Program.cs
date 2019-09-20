using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            int[] args = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elementsToPush = args[0];
            int elementsToPop = args[1];
            int elementContain = args[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                nums.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (nums.Count>=1)
                {
                    nums.Pop();
                }
            }

            bool contains = nums.Contains(elementContain);

            if (contains)
            {
                Console.WriteLine("true");
            }
            else 
            {
                if (nums.Count==0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(nums.Min());
                }
            }
        }
    }
}
