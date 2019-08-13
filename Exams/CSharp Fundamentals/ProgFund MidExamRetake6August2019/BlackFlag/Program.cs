using System;

namespace BlackFlag
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    totalPlunder += (dailyPlunder * 0.50);
                    totalPlunder -= (totalPlunder * 0.30);
                }
                else if (i % 3 == 0)
                {
                    totalPlunder += (dailyPlunder * 0.50);
                }
                else if (i % 5 == 0)
                {
                    totalPlunder -= (totalPlunder * 0.30);
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
