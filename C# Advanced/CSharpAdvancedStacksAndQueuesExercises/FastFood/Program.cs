using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] quantityOfOrders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(quantityOfOrders);
            int biggestOrder = orders.Max();
            int index = orders.Count;
            int totalOrders = 0;

            for (int i = 0; i < index; i++)
            {
                int currentOrder = orders.Peek();
                totalOrders += currentOrder;

                if (totalOrders <= quantityOfFood)
                {
                    orders.Dequeue();
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(", ", orders)}");
            }
        }
    }
}
