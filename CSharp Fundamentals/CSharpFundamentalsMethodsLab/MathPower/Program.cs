using System;

namespace MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = Power(number, power);
            Console.WriteLine(result);
        }

        static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
