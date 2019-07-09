using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(sideA, sideB));
        }

        static double RectangleArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }
    }
}
