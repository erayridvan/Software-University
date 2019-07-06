using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();


            while (true)
            {
                string[] info = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string curruntItem = info[0];

                if (info[0] == "buy")
                {
                    break;
                }

                double price = double.Parse(info[1]);
                int quantity = int.Parse(info[2]);

                if (!(products.ContainsKey(curruntItem)))
                {
                    products[curruntItem] = new Product();
                    products[curruntItem].price = price;
                    products[curruntItem].quantity = quantity;
                }
                else
                {
                    products[curruntItem].quantity += quantity;
                    products[curruntItem].price = price;
                }
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.price*item.Value.quantity):f2}");
            }
        }
    }
    class Product
    {
        public double price;
        public int quantity;
    }
}
