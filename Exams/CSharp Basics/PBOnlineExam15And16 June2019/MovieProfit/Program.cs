using System;

namespace MovieProfit
{
    class Program
    {
        static void Main()
        {
            string nameOfMovie = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfTickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double procentForSaloon = double.Parse(Console.ReadLine());

            double totalPriceForOneDay = numberOfTickets * ticketPrice;
            double totalPrice = totalPriceForOneDay * numberOfDays;
            double incomeForSaloon = totalPrice * (procentForSaloon/100);
            double incomeFromMovie = totalPrice - incomeForSaloon;

            Console.WriteLine($"The profit from the movie {nameOfMovie} is {incomeFromMovie:f2} lv.");
        }
    }
}
