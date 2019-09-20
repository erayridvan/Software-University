using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < index; i++)
            {
                int[] args = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int type = args[0];

                if (type==1)
                {
                    int elementToPush = args[1];
                    numbers.Push(elementToPush);
                }
                else if (type==2)
                {
                    numbers.Pop();
                }
                else if (type==3)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (type==4)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", " , numbers));
        }
    }
}
