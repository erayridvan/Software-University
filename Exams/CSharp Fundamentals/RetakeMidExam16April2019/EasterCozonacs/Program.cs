using System;
using System.Collections.Generic;
using System.Linq;
namespace EasterCozonacs
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double packOfEggsPrice = flourPrice * 0.75;
            double milkPrice = flourPrice + (flourPrice * 0.25);
            double quaterMilk = milkPrice / 4.0;
            double totalPriceForOneCozonac = packOfEggsPrice + flourPrice + quaterMilk;
            int colouredEggsCounter = 0;
            int cozonacCounter = 0;

            while (true)
            {
                if (budget< totalPriceForOneCozonac)
                {
                    break;
                }

                cozonacCounter++;
                if (cozonacCounter % 3==0)
                {
                    colouredEggsCounter -= (cozonacCounter - 2);
                }
                budget -= totalPriceForOneCozonac;
                colouredEggsCounter += 3;
            }

            Console.WriteLine($"You made {cozonacCounter} cozonacs! Now you have {colouredEggsCounter} eggs and {budget:f2}BGN left.");
        }
    }
}
