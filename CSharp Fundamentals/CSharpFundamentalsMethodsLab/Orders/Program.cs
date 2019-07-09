using System;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PriceCalculator(product, quantity);
        }

        static void PriceCalculator(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price = 1.5; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00;  break;
            }
            double totalPrice = price * quantity;

            Console.WriteLine("{0:f2}",totalPrice);
        }
    }
}
