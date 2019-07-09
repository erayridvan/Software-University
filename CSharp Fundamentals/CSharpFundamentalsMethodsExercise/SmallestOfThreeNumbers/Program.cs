using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var result = BiggerNumber(a, b, c);

            Console.WriteLine(result);
        }

        static int BiggerNumber(int a, int b, int c)
        {
            if (a<b && a<c)
            {
                return a;
            }
            else if (b<c && b<a)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
