using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            int[] args = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = args[0];
            int elementsToDequeue = args[1];
            int elementContain = args[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                nums.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                if (nums.Count >= 1)
                {
                    nums.Dequeue();
                }
            }

            bool contains = nums.Contains(elementContain);

            if (contains)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (nums.Count == 0)
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
