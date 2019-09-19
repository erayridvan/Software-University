using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                nums.Push(numbers[i]);
            }

            string input = string.Empty;
            while ((input=Console.ReadLine()) != "end")
            {
                string[] args = input.Split().ToArray();
                string command = args[0];

                if (command=="add")
                {
                    int firstNumber = int.Parse(args[1]);
                    int secondNumber = int.Parse(args[2]);

                    nums.Push(firstNumber);
                    nums.Push(secondNumber);
                }
                else if (command=="remove")
                {
                    int index = int.Parse(args[1]);

                    if (index<=nums.Count)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                sum += nums.Pop();
            }

            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
