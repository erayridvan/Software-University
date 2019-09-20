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

            int elementsToPop = args[1];
            int elementContain = args[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> nums = new Stack<int>(numbers);

            for (int i = 0; i < elementsToPop; i++)
            {
                if (nums.Count>=1)
                {
                    nums.Pop();
                }
            }

            if (nums.Contains(elementContain))
            {
                Console.WriteLine("true");
            }
            else if (nums.Count>1 && !(nums.Contains(elementContain)))
            {
                Console.WriteLine(nums.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
