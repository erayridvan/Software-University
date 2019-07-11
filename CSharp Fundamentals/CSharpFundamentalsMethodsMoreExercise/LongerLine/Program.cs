using System;

namespace LongerLine
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            FindLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void FindLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLine = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2))
                + Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            double secondLine = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2))
                + Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if (firstLine>secondLine)
            {
                bool closestPoint = ClosestPoint(x1, y1, x2, y2);

                if (closestPoint==false)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                bool closestPoint = ClosestPoint(x3, y3, x4, y4);

                if (closestPoint==false)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }

        static bool ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (firstPoint>secondPoint)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
