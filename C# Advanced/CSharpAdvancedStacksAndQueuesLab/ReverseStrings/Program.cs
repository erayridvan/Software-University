using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>();
            var input = Console.ReadLine();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
